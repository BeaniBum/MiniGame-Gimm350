using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyBlock : MonoBehaviour
{
     public void btnClicked(){
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 6;
        Debug.Log("Holy Block Selected!");
        managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
