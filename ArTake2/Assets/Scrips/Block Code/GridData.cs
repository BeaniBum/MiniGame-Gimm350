using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//struct is a data class that we make to do specific stuff (see vector3)
public struct PlacedBlock 
{
    public Block dataBlock;
    public Vector3Int gridPosition;

    public PlacedBlock (Block block, Vector3Int pos)
    {
        dataBlock = block;
        gridPosition = pos;
    }

    public BoundsInt pointsOccupied()
    {
        BoundsInt bounds = new BoundsInt();
        bounds.min = gridPosition;
        bounds.max = gridPosition + dataBlock.size;

        return bounds;
    }
    public bool contains(Vector3Int pos)
    {
        return pointsOccupied().Contains(pos);
    }

    public void rotateLeft()
    {
        dataBlock.transform.Rotate(new Vector3(0, -90, 0));

    }

    public void rotateRight()
    {
        dataBlock.transform.Rotate(new Vector3(0, 90, 0));
    }
    
}
