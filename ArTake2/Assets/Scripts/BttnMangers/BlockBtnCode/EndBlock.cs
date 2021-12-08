using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBlock : MonoBehaviour
{
     public void btnClicked(){
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 7;
        Debug.Log("End Block Selected!");
        managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
