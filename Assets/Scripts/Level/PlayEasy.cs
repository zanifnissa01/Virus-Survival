using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayEasy : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene("Game1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
