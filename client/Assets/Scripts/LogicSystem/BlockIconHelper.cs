﻿using protocol.cs_theircraft;
using System.Collections.Generic;
using UnityEngine;

public class BlockIconHelper
{
    public static Sprite GetIcon(CSBlockType type)
    {
        return Resources.Load<Sprite>("GUI/icon/" + type.ToString());
    }

    public static Texture2D GetIcon(string id, short data)
    {
        NBTObject generator = NBTGeneratorManager.GetObjectGenerator(id);
        if (generator != null)
        {
            string path = generator.GetIconPathByData(data);
            return Resources.Load<Texture2D>(generator.pathPrefix + path);
        }
        Debug.Log("no icon, id=" + id + ",data=" + data);
        return null;
    }
}
