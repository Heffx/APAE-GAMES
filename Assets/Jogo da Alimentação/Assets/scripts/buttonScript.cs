using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {

	//Sounds
	private AudioSource correct;
	public AudioClip btn;




	private int mode;


	energyBar a;

	// Use this for initialization
	void Start () {
		correct = gameObject.GetComponent<AudioSource>();
		correct.clip = btn;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	// menu -0
	// world - 1
	// endless - 2
	// fim - 3
    //Voltar

    public void voltar()
    {
        SceneManager.LoadScene("P_Main Menu");
    }

	// Menu
	public void menu(){
		correct.Play ();
		SceneManager.LoadScene ("B_Main Menu");
	}


	// World
	public void world(){
		correct.Play ();
		SceneManager.LoadScene("B_fase1");
	}


	// End
	public void endless(){
		correct.Play ();
		SceneManager.LoadScene("B_endless");
	}



	// Exit
	public void fim(){
		correct.Play ();
		Application.Quit();
	}

	// WIN
	public void win(){
		correct.Play ();
		SceneManager.LoadScene("B_win");
	}


	// inst 1
	public void inst(){
		correct.Play ();
		SceneManager.LoadScene("B_Intrução 1");
	}


	// f1
	public void f1(){
		correct.Play ();
		SceneManager.LoadScene("B_Intrução 2");

    }

	// f2
	public void f2(){
		correct.Play ();
		SceneManager.LoadScene("B_Intrução 3");

    }

}
