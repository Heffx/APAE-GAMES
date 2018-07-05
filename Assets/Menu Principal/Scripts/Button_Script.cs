using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Script : MonoBehaviour {

	public void MemoryGame()
    {
        SceneManager.LoadScene("H_Main Menu");
    }

    public void FoodGame()
    {
        SceneManager.LoadScene("B_Main Menu");
    }

    public void Pluzze()
    {
        SceneManager.LoadScene("J_Main Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
