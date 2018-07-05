using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	private Sprite CardBack;

	public Sprite[] CardFace;

	public List<Sprite> gameCardFace = new List<Sprite> ();

	public List<Button> btns = new List<Button> ();

    [SerializeField]
    private AudioClip flip;
    private AudioSource flipper;

    public Text pontuacao;


    private bool firstGuess, secondGuess;
	private int firstID, secondID;
	private int countGuess;
	private int countCorrectGuess;
	private int gameGuess;
	private int firstGuessIndex, secondGuessIndex;
	private string firstGuessPuzzle, secondGuessPuzzle;
	public static int Level = 1;
	public static int score;
	private int errors;
    public static int scorr;


	void Awake(){
		CardFace = Resources.LoadAll<Sprite> ("Images/Cartas");
	}

    void _SetAudio()
    {
        flipper = gameObject.GetComponent<AudioSource>();
        flipper.clip = flip;
    }


	void Start (){
        _SetAudio();
        score = 0;
		errors = 0;
		GetButtons ();
		AddListeners ();
		AddGamePluzzles ();
		Suffle (gameCardFace);
		gameGuess = gameCardFace.Count / 2;
	}

	void GetButtons(){
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("Card");

		for (int i = 0; i < objects.Length; i++) {
			btns.Add (objects [i].GetComponent<Button> ());
			btns [i].image.sprite = CardBack;
		}
	}

	void AddListeners(){
		foreach (Button btn in btns) {
			btn.onClick.AddListener (() => PickAPluzze ());
		}
	}

	void AddGamePluzzles(){
		int looper = btns.Count;
		int index = 0;

		for(int i = 0; i < looper; i++){
			if(index == looper / 2){
				index = 0;
			}
			gameCardFace.Add(CardFace[index]);

			index++;

		}
	}



	public void PickAPluzze(){
	string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

		if (!firstGuess) {

			firstID = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			firstGuess = true;
			firstGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			firstGuessPuzzle = gameCardFace [firstGuessIndex].name;
			countGuess++;
			btns [firstGuessIndex].image.sprite = gameCardFace [firstGuessIndex];
            flipper.Play();


        } else if (!secondGuess) {

			secondID = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
			if (firstID != secondID) {
				secondGuess = true;
				secondGuessIndex = int.Parse (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
				secondGuessPuzzle = gameCardFace [secondGuessIndex].name;
				btns [secondGuessIndex].image.sprite = gameCardFace [secondGuessIndex];
				countGuess++;
                flipper.Play();
                StartCoroutine (CheckIfThePuzzleMatch ());
			}
		}
	}

	IEnumerator CheckIfThePuzzleMatch(){

		yield return new WaitForSeconds (.5f);

		if (firstGuessPuzzle == secondGuessPuzzle) {

			yield return new WaitForSeconds (.2f);

			btns [firstGuessIndex].interactable = false;
			btns [secondGuessIndex].interactable = false;

			score += 100;
            pontuacao.text = " " +score;
            LevelMenuScript.match -= 1;
            Debug.Log(LevelMenuScript.match);
			CheckTheGameIsFinished ();

		} else {

			yield return new WaitForSeconds (.5f);

			score -= 50;
            pontuacao.text = " " +score;
            errors += 1;
            flipper.Play();
            btns [firstGuessIndex].image.sprite = CardBack;
			btns [secondGuessIndex].image.sprite = CardBack;
		}

		yield return new WaitForSeconds (.5f);

		firstGuess = secondGuess = false;
	}

	void CheckTheGameIsFinished(){
		countCorrectGuess++;
		if (countCorrectGuess == gameGuess) {
            if(LevelMenuScript.match == 0)
            {
                SceneManager.LoadScene("H_Win");
            }
			Debug.Log ("Game Finished");
			Level += 1;
            scorr = score;
			Debug.Log ("Level: " + Level);
            Debug.Log("Score: " + scorr);
        }

	}

	void Suffle(List<Sprite> list){
		for (int i = 0; i < list.Count; i++) {
			Sprite temp = list [i];
			int randomIndex = Random.Range (i, list.Count);
			list [i] = list [randomIndex];
			list [randomIndex] = temp;
		}
	}


}

