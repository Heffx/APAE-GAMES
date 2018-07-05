using UnityEngine;
using System.Collections;

public class followingCamera1 : MonoBehaviour {

	[SerializeField]
	Transform target; //Target followed

	Vector3 offset;




	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + offset;
	}



}
