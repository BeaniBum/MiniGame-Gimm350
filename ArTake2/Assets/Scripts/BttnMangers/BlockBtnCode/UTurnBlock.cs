using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UTurnBlock : MonoBehaviour
{
    public void btnClicked(){
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 2;
        Debug.Log("UTurn Block Selected!");
        managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
