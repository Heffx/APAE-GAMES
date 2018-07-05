using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
    private int pelada;

    private void Start()
    {
        pelada = WinScripts.level;

        
    }
    
   public void click()
    {
        if (pelada == 1)
        {
            SceneManager.LoadScene("J_Type1");
        }

        if (pelada == 2)
        {
            SceneManager.LoadScene("J_Type2");
        }

        if (pelada == 3)
        {
            SceneManager.LoadScene("J_Type3");
        }

    }
    	

    

}