using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public void voltar()
    {
        SceneManager.LoadScene("P_Main Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene("H_Level Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void fases()
    {
        SceneManager.LoadScene("H_Level Menu");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
