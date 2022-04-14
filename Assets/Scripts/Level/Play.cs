using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void Easy()
    {
        SceneManager.LoadScene("Game1");
    }

    public void Medium()
    {
        SceneManager.LoadScene("Game");
    }

    public void Hard()
    {
        SceneManager.LoadScene("Game3");
    }

    public void KembaliMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
