using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleCollision : MonoBehaviour
{
    public Rigidbody marbleRig;
    public GameObject WinSprite;
    public GameObject canvas;
    public BttnManager bttnManager;
    public Vector3 startPosition,startVelocity;


    // BttnManager bttn;
    //if object tagged marble hits object tagged EndSpawn Call Win
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EndSpawn")
        {
            WinSprite.SetActive(true);
        }
    }
    public void Start()
    {
        startPosition = this.transform.position;
        startVelocity = new Vector3(0f,0f,0f);
        canvas = GameObject.Find("Canvas");
        bttnManager = canvas.GetComponent<BttnManager>();
        
}
    public void Update()
    {
        
        if(bttnManager.dropMarble == true)
        {
            DropMarble();
        }

        if (bttnManager.reset == true)
        {
            ResetMarble();
        }



    }
    public void DropMarble ()
    {
        marbleRig.useGravity = true;

    }
    public void ResetMarble()
    {
        this.transform.position = startPosition;
        this.marbleRig.velocity = startVelocity;
        marbleRig.useGravity = false;
        bttnManager.dropMarble = false;
        bttnManager.reset = false;
    }
}
