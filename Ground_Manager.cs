using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Manager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0f;
    public float tileLength = 85f;
    public int numberofTiles = 2;
    public Transform palyerTransform;
    void Start()
    {
        for(int i= 0;i< numberofTiles;i++)
        {
            if(i== 0)
            {
                SpawnTile(0);
            }
            else
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }

    }

    void Update()
    {
        if(palyerTransform.position.z > zSpawn-(numberofTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }
    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }
}
