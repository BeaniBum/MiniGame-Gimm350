using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenBttnManager : MonoBehaviour
{
    public void StartPlayScreen()
    {
        SceneManager.LoadScene("PlayScreen");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
