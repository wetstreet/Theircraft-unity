﻿using protocol.cs_theircraft;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBTSugarCane : NBTBlock
{
    public override SoundMaterial soundMaterial { get { return SoundMaterial.Grass; } }

    public override bool isTransparent { get { return true; } }

    public override bool isCollidable { get { return false; } }

    List<int> triangles = new List<int>();

    public override void GenerateMeshInChunk(NBTChunk chunk, byte blockData, Vector3Int pos, List<Vector3> vertices, List<Vector2> uv)
    {
        AddDiagonalFace(vertices, uv, triangles, pos);
        AddAntiDiagonalFace(vertices, uv, triangles, pos);
    }

    public override void AfterGenerateMesh(List<List<int>> trianglesList, List<Material> materialList)
    {
        trianglesList.Add(triangles);
        materialList.Add(Resources.Load<Material>("Materials/block/sugar_cane"));
    }

    public override void ClearData()
    {
        triangles.Clear();
    }
}