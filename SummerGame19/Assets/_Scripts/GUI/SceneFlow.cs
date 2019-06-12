using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{

	public void NewGame()
    {
        SceneManager.LoadScene("MainShooter");
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("MainUI");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
