using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCards : MonoBehaviour {

	[SerializeField]
	private Transform CardPluzze;

	[SerializeField]
	private GameObject btn;

    public int constraintCount;


    void Awake (){

     
		for (int i = 0; i < LevelMenuScript.cards; i++) {
			GameObject button = Instantiate (btn);
			button.name = "" + i;
			button.transform.SetParent (CardPluzze, false);
            
		}
	}

}
