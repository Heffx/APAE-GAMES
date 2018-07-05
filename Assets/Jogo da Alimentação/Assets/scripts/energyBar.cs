using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class energyBar : MonoBehaviour {


	//energy bar
	public static List<bool> bar = new List<bool>();
	public int size=0;

	// Points
	public static int points;

	// List of resources
	public Sprite[] faces;
	public Button f;


	// to hide them
	//son.active = false;

	//The last upper count
	private int count;

	public static int received;

	//time that this one is alive
	private float time;

	GameObject son;



	// Mode of game
	public static int mode;

	// Use this for initialization
	void Start () {

		fase();
	}

	void Awake(){
		faces = Resources.LoadAll<Sprite> ("faces/faces");
	}

	// Update is called once per frame
	void Update () {
		
		// Face inserida
		if (count == 10){
			f.image.sprite = faces [2];
		}else if (count >= 8){
			f.image.sprite = faces [0];
		}else if (count >= 6){
			f.image.sprite = faces [1];
		}else if (count >= 4){
			f.image.sprite = faces [3];
		}else if (count >= 2){
			f.image.sprite = faces [5];
		}else{
			f.image.sprite = faces [4];
		}




		// Ate bad food
		if (received == 0) {
			received = -1;
			time = 0;

			// Only earse if not empty
			if (count > 0) {

				// Erase the son
				son = this.transform.Find ("bar").transform.Find (count.ToString ()).gameObject;
				son.active = false;

				// Decrease count
				count--;
			}
			// Good Food
		} else if (received == 1) {
			received = -1;
			time = 0;
			//Only if less than the max
			if (count < 10) {
				//Increase the counter
				count++;

				//Show this son
				son = this.transform.Find ("bar").transform.Find (count.ToString ()).gameObject;
				son.active = true;

			}
		
		// Ate nothing
		} else {

			//checking Game Over
			if (count==0){gameOver();}

			if (!wait (3)) {
				return;
			}
			//Change time to 0
			time = 0;

			//Checking if its more or equal 0
			if (count > 0) {
				//Erase the son
				son = this.transform.Find ("bar").transform.Find (count.ToString ()).gameObject;
				son.active = false;

				//Decrease the counter
				count--;
			}
		}
			
	}

	// This waits some seconds
	bool wait(float t){
		time += Time.deltaTime;
		if (time > t){
			return true;
		}
		return false;
	}

	// Fase 1
	void fase(){
		bar = new List<bool> (11);
		points = 0;
		count = 10;
		time = 0f;
		received = -1;
		//1 - World
		mode = 1;
	}

	// Game Over
	void gameOver(){
		SceneManager.LoadScene("B_gameOver");
	}

}
