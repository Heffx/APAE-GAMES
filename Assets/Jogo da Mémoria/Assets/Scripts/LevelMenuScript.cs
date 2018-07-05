using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenuScript : MonoBehaviour {
    

    public static int cards;
    public static int match;

    public void voltar()
    {
        SceneManager.LoadScene("H_Main Menu");
    }
    


    public void Level1()
    {
        cards = 6;
        match = 3;
        SceneManager.LoadScene("H_Level 1");
    }

    public void Level2()
    {
        cards = 8;
        match = 4;
        SceneManager.LoadScene("H_Level 2");
    }

    public void Level3()
    {
        cards = 12;
        match = 6;
        SceneManager.LoadScene("H_Level 3");
    }

    public void Level4()
    {
        cards = 16;
        match = 8;
        SceneManager.LoadScene("H_Level 4");
    }

    public void Level5()
    {
        cards = 20;
        match = 10;
        SceneManager.LoadScene("H_Level 5");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
