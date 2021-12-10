using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleMethod : MonoBehaviour
{
    //public GameObject test;
    //Marble marble = new Marble();
    public Marble marble;
    //public Rigidbody hel;
    public void DropMarble(Marble marble)
    {
        marble.marbleSound.Play();
        marble.marbleRig.useGravity = true;
    }
}
