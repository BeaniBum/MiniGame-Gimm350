using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public List<Block> blockPrefabs;
    public List <PlacedBlock> grid = new List<PlacedBlock>();
    public Button startButton; 

    public void Start()
    {
        //AddBlock(1, new Vector3Int(0, 0, 0));
        //startButton.onClick.AddListener(LoadScene("PlayScreen"));
       

    }
    public void AddBlock(int choice, Vector3Int pos )
    {
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

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene("PlayScreen");
    }
}
