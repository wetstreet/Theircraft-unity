using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class NBTPlant : NBTBlock
{
    protected int plantIndex;
    public virtual int GetPlantIndexByData(NBTChunk chunk, Vector3Int pos, int data) { return GetPlantIndexByData(chunk, data); }

    public virtual int GetPlantIndexByData(NBTChunk chunk, int data) { return GetPlantIndexByData(data); }

    public virtual int GetPlantIndexByData(int data) { return 0; }

    public override float breakNeedTime { get { return 0; } }

    public override SoundMaterial soundMaterial { get { return SoundMaterial.Grass; } }

    public override bool isTransparent { get { return true; } }

    public override bool isCollidable { get { return false; } }

    public override bool hasDropItem { get { return false; } }

    public override void AddCube(NBTChunk chunk, byte blockData, Vector3Int pos, NBTGameObject nbtGO)
    {
        plantIndex = GetPlantIndexByData(chunk, pos, blockData);
        tintColor = GetTintColorByData(chunk, pos, blockData);

        float skyLight = chunk.GetSkyLight(pos.x, pos.y, pos.z);

        AddDiagonalFace(nbtGO.nbtMesh, pos, skyLight);
        AddAntiDiagonalFace(nbtGO.nbtMesh, pos, skyLight);
    }

    protected Color tintColor;

    protected virtual Color GetTintColorByData(NBTChunk chunk, Vector3Int pos, byte data) { return GetTintColorByData(chunk, data); }
    protected virtual Color GetTintColorByData(NBTChunk chunk, byte data) { return Color.white; }

    public override Color GetFrontTintColorByData(NBTChunk chunk, Vector3Int pos, byte data)
    {
        return GetTintColorByData(chunk, pos, data);
    }

    void AddDiagonalFace(NBTMesh mesh, Vector3Int pos, float skyLight)
    {
        AddFace(mesh, pos, farBottomLeft, farTopLeft, nearTopRight, nearBottomRight, plantIndex, tintColor, skyLight, Vector3.zero);
    }

    void AddAntiDiagonalFace(NBTMesh mesh, Vector3Int pos, float skyLight)
    {
        AddFace(mesh, pos, nearBottomLeft, nearTopLeft, farTopRight, farBottomRight, plantIndex, tintColor, skyLight, Vector3.zero);
    }
    
    public override string pathPrefix { get { return "GUI/block/"; } }

    public override Material GetItemMaterial(byte data)
    {
        if (!itemMaterialDict.ContainsKey(data))
        {
            Material mat = new Material(Shader.Find("Custom/BlockShader"));
            Texture2D tex = Resources.Load<Texture2D>(pathPrefix + GetIconPathByData(data));
            mat.mainTexture = tex;
            itemMaterialDict.Add(data, mat);
        }
        return itemMaterialDict[data];
    }

    public override Mesh GetItemMesh(NBTChunk chunk, byte data)
    {
        byte index = (byte)(data % 4);
        if (!itemMeshDict.ContainsKey(index))
        {
            Texture2D tex = Resources.Load<Texture2D>(pathPrefix + GetIconPathByData(index));
            Mesh mesh = ItemMeshGenerator.instance.Generate(tex);
            itemMeshDict.Add(index, mesh);
        }
        return itemMeshDict[index];
    }
}
