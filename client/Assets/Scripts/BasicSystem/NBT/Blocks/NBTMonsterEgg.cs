using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBTMonsterEgg : NBTBlock
{
    public override string name { get { return "Monster Egg"; } }
    public override string id { get { return "minecraft:monster_egg"; } }

    public override string GetIconPathByData(short data)
    {
        switch (data)
        {
            case 0:
                return "Stone";
            case 1:
                return "Cobblestone";
        }

        throw new System.Exception("no icon,data=" + data);
    }

    public override void Init()
    {
        UsedTextures = new string[] { "stone", "cobblestone" };
    }

    public override float hardness { get { return 1.5f; } }

    public override SoundMaterial soundMaterial { get { return SoundMaterial.Stone; } }

    public override string GetBreakEffectTexture(byte data) { return "stone"; }


    int GetIndexByData(int data)
    {
        switch (data)
        {
            case 0:
                return TextureArrayManager.GetIndexByName("stone");
            case 1:
                return TextureArrayManager.GetIndexByName("cobblestone");
        }
        throw new System.Exception("no data,data=" + data);
    }

    public override int GetTopIndexByData(NBTChunk chunk, int data) { return GetIndexByData(data); }
    public override int GetBottomIndexByData(NBTChunk chunk, int data) { return GetIndexByData(data); }
    public override int GetFrontIndexByData(NBTChunk chunk, int data) { return GetIndexByData(data); }
    public override int GetBackIndexByData(NBTChunk chunk, int data) { return GetIndexByData(data); }
    public override int GetLeftIndexByData(NBTChunk chunk, int data) { return GetIndexByData(data); }
    public override int GetRightIndexByData(NBTChunk chunk, int data) { return GetIndexByData(data); }
}
