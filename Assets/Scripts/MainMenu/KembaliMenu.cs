using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KembaliMenu : MonoBehaviour
{
    public void Kembali()
    {
        SceneManager.LoadScene("Level");
    }
}
