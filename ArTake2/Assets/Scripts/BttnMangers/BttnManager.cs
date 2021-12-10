using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BttnManager : MonoBehaviour
{
    public GameObject CreateButton;
    public GameObject CRATEBUTTONON;
    public GameObject MarbleButton;
    public GameObject MarbleBUTTONON;
    public GameObject BlockMenu;
    
    public AudioSource marbleSound;

    public bool createMode;
    public bool marbleMode;
    public bool dropMarble;
    public bool menuActive;

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

    public void BlockMenuOpen()
    {
        BlockMenu.SetActive(true);
        menuActive = true;
    }
    public void BlockMenuClose()
    {
        BlockMenu.SetActive(false);
        menuActive = false;
    }

    public void RotateBlock()
    {
        
    }

    public void SelectBlock()
    {
        
    }
    public void DeleteBlock()
    {

    }

    public void DropMarble()
    {
        marbleSound.Play();
        dropMarble = true;
    }

    public void ResetMarble()
    {

    }

}
