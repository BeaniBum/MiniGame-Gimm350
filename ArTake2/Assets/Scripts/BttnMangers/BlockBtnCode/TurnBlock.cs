using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBlock : MonoBehaviour
{
     public void btnClicked(){
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 3;
        Debug.Log("Turn Block Selected!");
        managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
