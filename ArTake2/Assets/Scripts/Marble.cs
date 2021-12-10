using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour
{
    //public GameObject marble;
    public Rigidbody marbleRig;
    public GameObject WinSprite;
    public AudioSource marbleSound;

    //public Marble (Rigidbody marbleRig, GameObject WinSprite, Audio )
    //if object tagged marble hits object tagged EndSpawn Call Win
   /* public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EndSpawn")
        {
            WinSprite.SetActive(true);
        }
    }

   /* public void DropMarble ()
    {
        GameObject canvas = GameObject.Find("Canvas");
        BttnManager bttnManager = canvas.GetComponent<BttnManager>();

        if (bttnManager.dropMarble)
        {
            marbleRig.constraints = RigidbodyConstraints.None;
        }

    }*/
}
