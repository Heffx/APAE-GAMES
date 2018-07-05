using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl : MonoBehaviour {

	//--------------------ENDLESS VARS------------------//
	public int points;
	//--------------------ENDLESS VARS------------------//


	// ------------LIFE BAR-------------//
	//Life Bar
	public static List<bool> lifeBar = new List<bool>();
	//The last upper count
	private int lifeUpper = 3;
	// ------------LIFE BAR-------------//





	// ------------COUNT BAR-------------//
	public static List<bool> countBar = new List<bool>();
	private int countUpper=6;
	// ------------COUNT BAR-------------//



	// to hide them
	//son.active = false;

	public static int received;

	GameObject son;


	// Use this for initialization
	void Start () {
		points = 0;
		received = -1;

		//Counter
		countBar = new List<bool> (10);

		lifeBar = new List<bool> (31);
	}


	// Update is called once per frame
	void Update () {

		
		// Ate bad food
		if (received == 0) {
			
			//Counting lifes - GAME OVER
			if (lifeUpper == 1){
				SceneManager.LoadScene (3);
			}
				

			//Hide one life counter
			son = this.transform.Find("lifeBar").transform.Find (lifeUpper.ToString()).gameObject;
			son.active = false;

			//Decrease life
			lifeUpper--;


			//Good Food
		} else if (received == 1) {

			//Increasing the counter
			if (countUpper > 1) {
				son = this.transform.Find ("countBar").transform.Find (countUpper.ToString ()).gameObject;
				son.active = false;
				countUpper--;
			
			//CountUpper e zero, ganha vida
			} else {
				
				// If I gained a life
				if (lifeUpper < 3) {
					lifeUpper++;
				}

				countUpper = 6;
				int a;
				//Mostra todas as barrrinhas
				for (a = 1; a < 7; a++) {
					son = this.transform.Find ("countBar").transform.Find (a.ToString ()).gameObject;
					son.active = true;
				}


				// Showing This new Life bar
					son = this.transform.Find ("lifeBar").transform.Find (lifeUpper.ToString ()).gameObject;
					son.active = true;
			}

		}

		received = -1;
	}
		

	// Game Over
	void gameOver(){
		SceneManager.LoadScene(3);
	}

}
