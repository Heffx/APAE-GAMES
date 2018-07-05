using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScripts : MonoBehaviour {

    public static int level = 1;

    private void Start()
    {
        level += 1;
    }
    public void click()
    {
        if (level == 2)
        {
            SceneManager.LoadScene("J_Dica_Lv2");
        }

        if (level == 3)
        {
            SceneManager.LoadScene("J_Dica_Lv3");
        }

        if (level == 4)
        {
            SceneManager.LoadScene("J_Main Menu");
        }

    }
}
