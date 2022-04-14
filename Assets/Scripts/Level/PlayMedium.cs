using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMedium : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
