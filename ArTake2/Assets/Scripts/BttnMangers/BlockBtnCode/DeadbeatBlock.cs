using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadbeatBlock : MonoBehaviour
{
    public AudioSource blockSound;

    public void btnClicked()
    {
        blockSound.Play();

        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 5;
        Debug.Log("DeadBeat Block Selected!");
        Debug.Log(managerChoice.choice);
        //managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
