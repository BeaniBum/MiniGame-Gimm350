using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBlock : MonoBehaviour
{
    public AudioSource blockSound;
    public void btnClicked()
    {
        blockSound.Play();

        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 0;
        Debug.Log("Start Block Selected!");
        //managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
