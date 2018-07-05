using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj : MonoBehaviour {

	// 
	[SerializeField]
	GameObject pl;

	private float dist;

	[SerializeField]
	private AudioSource bite;

	// Use this for initialization
	void Start () {
		dist = 10;


	}
	
	// Update is called once per frame
	void Update () {
		if (pl.transform.position.z > (transform.position.z+dist)){
			//Debug.Log ("acabou");
			//Destroy (this.gameObject);
			//Debug.Log ("fim");
		}
	}


	//Colision
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "player") {
			//Animacao
			//som


			//Destroy
			Destroy(this.gameObject);
		}
			
	}

}
