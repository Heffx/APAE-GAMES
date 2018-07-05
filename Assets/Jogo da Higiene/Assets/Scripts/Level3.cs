using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Level3 : MonoBehaviour {

	public string resposta="";
	public int ponto;
	public float tempo=60;

	public void Update()
	{
		tempo -= Time.deltaTime; 
		Debug.Log (tempo);
		if (tempo <= 0f) 
		{
			Application.LoadLevel ("J_Type3");
		}
	}

	public void textoResposta(string text)
	{
		resposta = text.ToUpper ();
		//Debug.Log (resposta);
	}

	public void clicou()
	{	
		//Debug.Log (resposta);
		if (resposta == "ESCOVA") {
			Application.LoadLevel ("J_Win");
			ponto += 10;
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

	public void OnGUI()
	{
		GUI.Label(new Rect(140,800,200,20), "Tempo restante: " + (int)tempo);
	}
}

