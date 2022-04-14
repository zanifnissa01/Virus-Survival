using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
