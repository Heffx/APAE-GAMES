using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	private Rigidbody body;
	//the above command make possible sett the speed value via menu
	[SerializeField]
	public float speed; 

	//Length in Z of an object that we wanna build
	private float lengthZ = 7.6f;

	public static float z;


	// Use this for initialization
	void Start () {

		//get the actuall rigidbody
		body = this.GetComponent<Rigidbody>();
		//Setting the velocity
		body.velocity = new Vector3(0f, 0f, speed);

	}
	
	// Update is called once per frame
	void Update () {
		z = transform.position.z;

		if (transform.position.z >= 314 ){
			//GANHOU
			SceneManager.LoadScene("B_win");
		}


		//check if some key was pressed
		float amToMove = Input.GetAxisRaw ("Horizontal") * speed/2 * Time.deltaTime;

		// Update the velocity
		body.velocity = new Vector3(0f, 0f, speed);

		// Only move if is in limit x.
		transform.Translate (Vector3.right * amToMove);

		// Travamento em X
		if (transform.position.x <= -0.9278f)
			transform.position = new Vector3 (-0.921f, transform.position.y, transform.position.z);
		else if (transform.position.x >= 1.6769f)
			transform.position = new Vector3 (1.6768f, transform.position.y, transform.position.z);
		}
}
