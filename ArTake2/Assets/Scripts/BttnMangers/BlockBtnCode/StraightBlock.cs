﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightBlock : MonoBehaviour
{
     public void btnClicked(){
        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 4;
        Debug.Log("Straight Block Selected!");
        managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}