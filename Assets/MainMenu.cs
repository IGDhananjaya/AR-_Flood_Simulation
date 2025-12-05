using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;


public class MainMenu : MonoBehaviour
{
    public void ButtonExit()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void ScanAR()
    {
        SceneManager.LoadScene("ScanAR");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Guide()
    {
        SceneManager.LoadScene("Guide");
    }
}
