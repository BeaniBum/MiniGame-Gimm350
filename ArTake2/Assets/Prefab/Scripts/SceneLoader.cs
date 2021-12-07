using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    public RectTransform StartButton;
    public RectTransform endButton;

    public void pressStartButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void pressExitButton()
    {
        Application.Quit();
    }
}
