﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PathwayBlocks : MonoBehaviour
{
    private GameObject m_RefToChild = null;

    // Start is called before the first frame update
    void OnEnable()
    {
        for(int i = 0; i < transform.childCount; ++i)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        
        switch(GetComponentInParent<Spawner>().GetCurrentTheme())
        {
            case ECurrentTheme.e_Sand:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/SandBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            case ECurrentTheme.e_Dirt:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/DirtBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            case ECurrentTheme.e_Grass:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/GrassBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            case ECurrentTheme.e_Snow:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/SnowBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            case ECurrentTheme.e_CobbleStone:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/CobbleStoneBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            case ECurrentTheme.e_Stone:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/StoneBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            case ECurrentTheme.e_Lava:
                {
                    m_RefToChild = Instantiate((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Model/BlocksAndTreesPack/Blocks/LavaBlock.prefab", typeof(GameObject)), transform);
                    break;
                }
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
