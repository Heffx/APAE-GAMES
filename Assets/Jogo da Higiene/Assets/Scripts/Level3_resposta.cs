using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level3_resposta : MonoBehaviour {

	public string resposta;
	public int ponto;

	public void textoResposta(string text)
	{
		resposta = text.ToUpper ();
		//Debug.Log (resposta);
	}

	public void clicou()
	{	
		Debug.Log (resposta);
		if (resposta == "FIO DENTAL") {
			Application.LoadLevel ("J_Finish");
		} 
		else 
		{
			Application.LoadLevel ("J_Lose");
		}
	}

	public void ChangeScene(string sceneName)
	{	

		Application.LoadLevel (sceneName);
	}
		
}

