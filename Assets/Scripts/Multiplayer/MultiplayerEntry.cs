﻿using UnityEngine;
using Theircraft;

public class MultiplayerEntry : MonoBehaviour {

    bool playerInited = false;

    // Use this for initialization
    void Start ()
    {
        GameKernel.Create();
        ChatPanel.ShowChatPanel();
        ItemSelectPanel.Show();

        NetworkManager.Register(CSMessageType.CHUNK_INFO_RES, ChunkInfoRes);
        ChunkInfoReq(new Vector2Int(0, 0));
        ChunkInfoReq(new Vector2Int(-1, 0));
        ChunkInfoReq(new Vector2Int(0, -1));
        ChunkInfoReq(new Vector2Int(-1, -1));
    }
	
	// Update is called once per frame
	void Update () {

    }

    void ChunkInfoReq(Vector2Int chunk)
    {
        CSChunkInfoReq req = new CSChunkInfoReq
        {
            ChunkX = chunk.x,
            ChunkZ = chunk.y,
        };
        NetworkManager.Enqueue(CSMessageType.CHUNK_INFO_REQ, req);
    }

    void ChunkInfoRes(byte[] data)
    {
        CSChunkInfoRes rsp = NetworkManager.Deserialzie<CSChunkInfoRes>(data);
        Debug.Log("ChunkInfoRes=" + rsp.RetCode + "," + rsp.ChunkX + "," + rsp.ChunkZ);
        if (rsp.RetCode == 0)
        {
            //for (int i = 0; i < rsp.BlockList.Length; i++)
            //{
            //    print(rsp.BlockList[i].position);
            //}
            TerrainGenerator.GenerateChunkFromList(new Vector2Int(rsp.ChunkX, rsp.ChunkZ), rsp.BlockList);
            if (!playerInited)
            {
                PlayerController.Init();
                playerInited = true;
            }
        }
        else
        {
            FastTips.Show(rsp.RetCode);
        }
    }
}
