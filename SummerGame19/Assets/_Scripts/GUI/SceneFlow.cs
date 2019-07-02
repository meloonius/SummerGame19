using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{

    public void NewGame()
    {
        SceneManager.LoadScene("PlanetMap");
        Time.timeScale = 1f;
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Main_UI");
    }

    public void OpenPlanetMap()
    {
        SceneManager.LoadScene("PlanetMap");
    }

    public void OpenUpgradeUI()
    {
        SceneManager.LoadScene("Upgrade_UI");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
