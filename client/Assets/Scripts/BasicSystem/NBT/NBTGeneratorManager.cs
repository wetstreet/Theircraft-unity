﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBTGeneratorManager : MonoBehaviour
{
    public static Dictionary<byte, NBTBlock> generatorDict = new Dictionary<byte, NBTBlock>()
    {
        { 1, new NBTStone() },
        { 2, new NBTGrassBlock() },
        { 3, new NBTDirt() },
        { 4, new NBTCobblestone() },
        { 5, new NBTPlanks() },
        { 6, new NBTSapling() },
        { 7, new NBTBedrock() },
        { 9, new NBTStationaryWater() },
        { 12, new NBTSand() },
        { 13, new NBTGravel() },
        { 14, new NBTGoldOre() },
        { 15, new NBTIronOre() },
        { 16, new NBTCoalOre() },
        { 17, new NBTLog() },
        { 18, new NBTLeaves() },
        { 20, new NBTGlass() },
        { 21, new NBTRedstoneOre() },
        { 24, new NBTSandStone() },
        { 31, new NBTTallGrass() },
        { 32, new NBTDeadBush() },
        { 37, new NBTYellowFlower() },
        { 38, new NBTRedFlower() },
        { 39, new NBTBrownMushroom() },
        { 40, new NBTRedMushroom() },
        { 45, new NBTBrick() },
        { 49, new NBTObsidian() },
        { 53, new NBTOakStairs() },
        { 56, new NBTDiamondOre() },
        { 58, new NBTCraftingTable() },
        { 59, new NBTWheat() },
        { 60, new NBTFarmland() },
        { 67, new NBTCobblestoneStairs() },
        { 73, new NBTRedstoneOre() },
        { 78, new NBTSnowLayer() },
        { 81, new NBTCactus() },
        { 82, new NBTClay() },
        { 83, new NBTSugarCane() },
        { 85, new NBTFence() },
        { 97, new NBTMonsterEgg() },
        { 108, new NBTBrickStairs() },
        { 125, new NBTDoubleWoodenSlab() },
        { 126, new NBTWoodenSlab() },
        { 134, new NBTSpruceStairs() },
        { 135, new NBTBirchStairs() },
        { 136, new NBTJungleStairs() },
        { 161, new NBTLeaves2() },
        { 162, new NBTLog2() },
        { 175, new NBTLargeFlowers() },
    };

    public static List<NBTItem> itemList = new List<NBTItem>()
    {
        new NBTShears(),
        new NBTWheatSeeds(),
        new NBTWoodenHoe(),
        new NBTWoodenShovel(),
        new NBTWoodenPickaxe(),
        new NBTStick(),
        new NBTBucket(),
    };

    public static Dictionary<string, NBTBlock> id2generator = new Dictionary<string, NBTBlock>();

    public static Dictionary<string, NBTItem> id2item = new Dictionary<string, NBTItem>();

    public static Dictionary<string, byte> id2type = new Dictionary<string, byte>();

    public static void Init()
    {
        foreach (KeyValuePair<byte, NBTBlock> keyValue in generatorDict)
        {
            NBTBlock generator = keyValue.Value;
            generator.Init();

            if (generator.id != null)
            {
                id2generator.Add(generator.id, generator);
                id2type.Add(generator.id, keyValue.Key);
            }
        }

        foreach (NBTItem item in itemList)
        {
            if (item.id != null)
            {
                id2item.Add(item.id, item);
            }
        }
    }

    public static NBTBlock GetMeshGenerator(byte rawType)
    {
        if (generatorDict.ContainsKey(rawType))
        {
            return generatorDict[rawType];
        }
        return null;
    }

    public static NBTBlock GetMeshGenerator(string id)
    {
        if (id2generator.ContainsKey(id))
        {
            return id2generator[id];
        }
        return null;
    }

    public static NBTObject GetObjectGenerator(string id)
    {
        if (id2generator.ContainsKey(id))
        {
            return id2generator[id];
        }
        if (id2item.ContainsKey(id))
        {
            return id2item[id];
        }
        return null;
    }

    public static bool IsTransparent(byte rawType)
    {
        if (rawType == 0) return true;

        if (generatorDict.ContainsKey(rawType))
        {
            return generatorDict[rawType].isTransparent;
        }
        return false;
    }

    public static bool IsFence(byte rawType)
    {
        if (generatorDict.ContainsKey(rawType))
        {
            return generatorDict[rawType].isFence;
        }
        return false;
    }
}
