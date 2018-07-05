using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiable : MonoBehaviour {

	// Player
	float z;

	// Distance between objects
	private float dist = 10f;

	// To use sunds in your game you must be:
	//1 - An audio source component inside of your object that contains the script
	//2 - An AudioClip array, that will be contain the all sounds
	//3 - An AudioSource to reproduce them. They gonna be all the charateristics from the component.

	// An array of AudioClips. They are actually sounds for each food ate.
	public AudioClip[] shoot;
	//This Audio Source, is a variable that makes sound be heard.
	public AudioSource correct;

	//I need this one to wait until the correct time to destroy this object. If dont do it, the Destroy function doesnt wait for
	//the sound ending.
	float time;

	// Sets the kind of item
	//0 - Hot-dog
	//1 - Apple
	int kind=-1;

	// Use this for initialization
	void Start () {

		//Starting the Audio Source
		correct = gameObject.GetComponent<AudioSource>();

		if (transform.name=="0"){
			//Batata
			kind=0;
		}

		if (transform.name=="1"){
			//Apple
			kind=1;
		}


	}

	// Update is called once per frame
	void Update () {
		z = player.z;
		if (z > (transform.position.z+dist)){
			// Debug.Log ("acabou");
			Destroy (this.gameObject);
			// Debug.Log ("fim");
		}
	}


	// Colision
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "player") {
			// Animacao

			// Som
			correct.clip = shoot[kind];
			correct.Play ();


			// espero o som acabar
			//move para o inicio, para que essa DISGRACA suma da pelada
			transform.position = new Vector3 (0, 0, transform.position.z-dist/2); 

			//Muda o valor de variavel global dentro do energyBar.
			lvl.received=kind;

		}

	}



	//This waits some seconds
	bool wait(float t){
		time += Time.deltaTime;
		if (time > t){
			return true;
		}
		return false;
	}


}