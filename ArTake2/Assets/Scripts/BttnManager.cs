using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BttnManager : MonoBehaviour
{

 
    public GameObject CreateButton;
    public GameObject PlaceButton;
    public GameObject DeleteButton;
    public GameObject RotateButton;
    public GameObject MoveButton;
    public GameObject CRATEBUTTONON;

    public GameObject MarbleButton;
    public GameObject MarbleBUTTONON;
    public GameObject MarbleStart;
    public GameObject MarbleReset;
    

    public bool createMode;
    public bool marbleMode;
 

    public void CreateSelected()
    {
        CreateButton.SetActive(false);
        MarbleButton.SetActive(false);
        CRATEBUTTONON.SetActive(true);
        createMode = true;

    }

    public void MarbleSelected()
    {
        MarbleButton.SetActive(false);
        CreateButton.SetActive(false);
        MarbleBUTTONON.SetActive(true);
        marbleMode = true;
       
    }
    public void MenueBack()
    {
        if (createMode)
        {
            CreateButton.SetActive(true);
            MarbleButton.SetActive(true);
            CRATEBUTTONON.SetActive(false);
            createMode = false;
        }
        if (marbleMode)
        {
            MarbleButton.SetActive(true);
            CreateButton.SetActive(true);
            MarbleBUTTONON.SetActive(false);
            marbleMode = false;
        }
    }
    public void Homebttn()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void MoveBlock()
    {

    }

    public void RotateBlock()
    {

    }

    public void PlaceBlock()
    {

    }
    public void DeleteBlock()
    {

    }

    public void DropMarble()
    {

    }

    public void ResetMarble()
    {

    }

}
