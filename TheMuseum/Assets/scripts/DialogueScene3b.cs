using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour {
	public int primeInt =1; // This integer drives game progress!
	public Text Char1name;
	public Text Char1speech;
	public Text Char2name;
	public Text Char2speech;
	public Text Char3name;
	public Text Char3speech;
	public GameObject dialogue;
	public GameObject ArtChar1;
	public GameObject ArtBG1;
	public GameObject Choice1a;
	public GameObject nextButton;
	public GameObject NextScene1Button;
	//public GameObject gameHandler;
	//public AudioSource audioSource;
	private bool allowSpace = true;

	void Start(){         // initial visibility settings
		dialogue.SetActive(false);
		ArtChar1.SetActive(false);
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		NextScene1Button.SetActive(false);
		nextButton.SetActive(true);
	}

	void Update(){         // use spacebar as Next button
		if (allowSpace == true){
			if (Input.GetKeyDown("space")){
				talking();
			}
		}

	}

	public void talking(){         // main story function. Players hit next to progress to next int
		primeInt = primeInt + 1;
		Debug.Log("primeInt = " + primeInt);

		if (primeInt == 1){
			// AudioSource.Play();
		}
		else if (primeInt == 2){
			dialogue.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Thief 1";
			Char2speech.text = "It's gotta be around here somewhere";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt ==3){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Thief 2";
			Char3speech.text = "They always lay out these musuems in such confusing ways.";
		}
		else if (primeInt == 4){
			Char1name.text = "You";
			Char1speech.text = "I can't hear them that well. Better move closer.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "Thief 2";
			Char3speech.text = "I think there's someone behind that pillar.";  
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true); // try to run
		}
	}

	// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = "";
		Char1speech.text = "";
		Char2name.text = "Thief 1";
		Char2speech.text = "What was that?";
		Char3name.text = "";
		Char3speech.text = "";
		primeInt = 99;
		Choice1a.SetActive(false);
		//Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
	public void Choice1bFunct(){
		Char1name.text = "You";
		Char1speech.text = "If I hide behind this pillar I can hear what they say";
		Char2name.text = "";
		Char2speech.text = "";
		Char3name.text = "";
		Char3speech.text = "";
		primeInt = 199;
		Choice1a.SetActive(false);
		//Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	public void SceneChange2a(){
		SceneManager.LoadScene("End_Lose");
	}
	public void SceneChange2b(){
		SceneManager.LoadScene("End_Lose");
	}
}