using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour {

    public void Sair()
    {
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {

        Application.LoadLevel(sceneName);
    }

    public void Voltar()
    {
        SceneManager.LoadScene("P_Main Menu");
    }

    public void Proximo21()
    {
        SceneManager.LoadScene("J_Dica_Lv2.1");
    }

    public void Volta2(){
        SceneManager.LoadScene("J_Dica_Lv2");
    }


}
