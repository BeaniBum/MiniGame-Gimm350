using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public List<Block> blockPrefabs;
    public List <PlacedBlock> grid = new List<PlacedBlock>();
    public int choice;

    public void Start()
    {
        //AddBlock(1, new Vector3Int(0, 0, 0));
        GameObject spawner = GameObject.Find("SpawnManager");
        SpawnManager spawn = spawner.GetComponent<SpawnManager>();
        
    }
    public void AddBlock(int choice, Vector3Int pos )
    {
        Debug.Log("I chose " + choice);
        Block instBlock = Instantiate(blockPrefabs[choice]);
        
        PlacedBlock data = new PlacedBlock(instBlock,pos);
        data.rotateLeft();
        if (canPlace(data))
        {
            instBlock.transform.position = pos;
            grid.Add(data);
        }
        else
        {
            Debug.LogWarning("Cant do");
            Destroy(instBlock.gameObject);
        }
            
    }

    public bool canPlace(PlacedBlock newBlock)
    {
        BoundsInt newBlockBounds = newBlock.pointsOccupied();
        foreach(PlacedBlock block in grid)
        {
            foreach(Vector3Int point in newBlockBounds.allPositionsWithin)
            {
                if(block.contains(point))
                {
                    return false;
                }
            }   
        }
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
