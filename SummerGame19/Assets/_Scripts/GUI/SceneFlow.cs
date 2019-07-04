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
        Time.timeScale = 1f;
    }

    public void OpenPlanetMap()
    {
        SceneManager.LoadScene("PlanetMap");
        Time.timeScale = 1f;
    }

    public void OpenUpgradeUI()
    {
        SceneManager.LoadScene("Upgrade_UI");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenBoss1()
    {
        SceneManager.LoadScene("Boss1");
    }

    public void OpenBoss2()
    {
        SceneManager.LoadScene("Boss2");
    }

    public void OpenBoss3()
    {
        SceneManager.LoadScene("Boss3");
    }
}
