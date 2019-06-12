using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{

	public void NewGame()
    {
        SceneManager.LoadScene("Main_Shooter");
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Main_UI");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
