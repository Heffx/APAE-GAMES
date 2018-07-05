using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level2_resposta : MonoBehaviour {

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
		if (resposta == "ESCOVA DE DENTE") {
			Application.LoadLevel ("J_Win");
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

