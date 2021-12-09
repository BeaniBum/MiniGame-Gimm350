using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayBlock : MonoBehaviour
{
    public AudioSource blockSound;
    public void btnClicked()
    {
        blockSound.Play();

        GameObject managerObject = GameObject.Find("Manager");
        Manager managerChoice = managerObject.GetComponent<Manager>();
        managerChoice.choice = 1;
        Debug.Log("Gay Block Selected!");
        //managerChoice.AddBlock(managerChoice.choice, new Vector3Int(0,0,0));
    }
}
