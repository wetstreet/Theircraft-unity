﻿using System.Collections.Generic;
using UnityEngine;
using protocol.cs_enum;
using protocol.cs_theircraft;

public class MergeTestStart : MonoBehaviour
{
    int sight = 12;

    // Start is called before the first frame update
    void Start()
    {
        GameKernel.Create();
        ChatPanel.ShowChatPanel();
        ItemSelectPanel.Show();
        NetworkManager.Register(ENUM_CMD.CS_CHUNKS_ENTER_LEAVE_VIEW_RES, ChunksEnterLeaveViewRes);


        int start;
        int max;
        if (sight % 2 == 0)
        {
            int half = sight / 2;
            start = -half;
            max = half - 1;
        }
        else
        {
            int half = Mathf.FloorToInt(sight / 2);
            start = -half;
            max = half;
        }

        List<Vector2Int> preloadChunks = new List<Vector2Int>();
        for (int i = start; i < max; i++)
        {
            for (int j = start; j < max; j++)
            {
                preloadChunks.Add(new Vector2Int(i, j));
            }
        }

        ChunksEnterLeaveViewReq(preloadChunks);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChunksEnterLeaveViewReq(List<Vector2Int> enterViewChunks, List<Vector2Int> leaveViewChunks = null)
    {
        CSChunksEnterLeaveViewReq req = new CSChunksEnterLeaveViewReq();

        List<CSVector2Int> enter = new List<CSVector2Int>();
        foreach (Vector2Int chunk in enterViewChunks)
        {
            CSVector2Int c = new CSVector2Int
            {
                x = chunk.x,
                y = chunk.y
            };
            enter.Add(c);
        }
        req.EnterViewChunks.AddRange(enter);

        if (leaveViewChunks != null)
        {
            List<CSVector2Int> leave = new List<CSVector2Int>();
            foreach (Vector2Int chunk in leaveViewChunks)
            {
                CSVector2Int c = new CSVector2Int
                {
                    x = chunk.x,
                    y = chunk.y
                };
                leave.Add(c);
            }
            req.LeaveViewChunks.AddRange(leave);
        }

        //Debug.Log("CS_CHUNKS_ENTER_LEVAE_VIEW_REQ," + req.EnterViewChunks.Count + "," + req.LeaveViewChunks.Count);
        NetworkManager.Enqueue(ENUM_CMD.CS_CHUNKS_ENTER_LEVAE_VIEW_REQ, req);
    }

    void ChunksEnterLeaveViewRes(byte[] data)
    {
        CSChunksEnterLeaveViewRes rsp = NetworkManager.Deserialize<CSChunksEnterLeaveViewRes>(data);

        //Debug.Log("CSChunksEnterLeaveViewRes," + rsp.EnterViewChunks.Count + "," + rsp.LeaveViewChunks.Count);
        if (rsp.RetCode == 0)
        {
            test.GenerateChunk(rsp.EnterViewChunks);
            mergetestPlayerController.Init();
        }
        else
        {
            FastTips.Show(rsp.RetCode);
        }
    }
}
