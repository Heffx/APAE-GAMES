using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kk : MonoBehaviour {



	private Rigidbody body;

	// Use this for initialization
	void Start () {

		//get the actuall rigidbody
		body = this.GetComponent<Rigidbody>();
		//Setting the velocity
		body.velocity = new Vector3(0f, 0f, 1);
	}
	
	// Update is called once per frame
	void Update () {
		

		float amToMove = Input.GetAxisRaw ("Horizontal") * 1/2 * Time.deltaTime;
		// Update the velocity
		body.velocity = new Vector3(0f, 0f, 1);

		// Only move if is in limit x.
		transform.Translate (Vector3.right * amToMove);
	}
}
