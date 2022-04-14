using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayHard : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene("Game3");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
