using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2 : MonoBehaviour {
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
	public GameObject Choice1b;
	public GameObject nextButton;
	public GameObject NextScene1Button;
	public GameObject NextScene2Button;
	//public GameObject gameHandler;
	//public AudioSource audioSource;
	private bool allowSpace = true;

	void Start(){         // initial visibility settings
		dialogue.SetActive(false);
		ArtChar1.SetActive(false);
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false);
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
			Char1name.text = "You";
			Char1speech.text = "Good old Gallery Number 1. Full of my buddy Rembrandt.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt ==3){
			Char1name.text = "You";
			Char1speech.text = "Huh..? Do I hear voices?";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 4){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "???";
			Char2speech.text = "Do you see the [indistinct]";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 5){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "???";
			Char3speech.text = "[indistinct] where did you [indistinct]";
			//gameHandler.AddPlayerStat(1);
		}
		else if (primeInt == 6){
			Char1name.text = "You";
			Char1speech.text = "I don't think I recognize those voices. Maybe it's Rupert?";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";

			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "???";
			Char2speech.text = "Hi there! I'm Bob, one of the new late night curators.";  
			Char3name.text = "";
			Char3speech.text = "";  
		}

		else if (primeInt == 101){
			Char1name.text = "You";
			Char1speech.text = "I didn't know Late Night Curator was a job.";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "";
			Char3speech.text = "";  
		}

		else if (primeInt == 102){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Bob";
			Char2speech.text = "They're having us figure out the new exhibit while museum goers aren't around";  
			Char3name.text = "";
			Char3speech.text = "";  
		}

		else if (primeInt == 103){
			Char1name.text = "You";
			Char1speech.text = "Okay... is it just the two of you?";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "";
			Char3speech.text = "";  
		}

		else if (primeInt == 104){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Bob";
			Char2speech.text = "Us and Joey. He had to take a leak.";  
			Char3name.text = "";
			Char3speech.text = "";  
		}

		else if (primeInt == 105){
			Char1name.text = "You";
			Char1speech.text = "...Well, you have a good evening then.";
			Char2name.text = "";
			Char2speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";  
		}

		else if (primeInt == 106){
			Char1name.text = "You";
			Char1speech.text = "...Well, you have a good evening then.";
			Char2name.text = "";
			Char2speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";  
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true); // I better go check out the bathroom
		}



		else if (primeInt == 200){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "???";
			Char2speech.text = "They said it would be somewhere near this gallery"; 
			Char3name.text = "";
			Char3speech.text = "";
		}

		else if (primeInt == 201){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = ""; 
			Char3name.text = "???";
			Char3speech.text = "Well, it's clearly not here. We have to look somehwre else.";
		}

		else if (primeInt == 202){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "???";
			Char2speech.text = "I'm telling you what I know!"; 
			Char3name.text = "";
			Char3speech.text = "";
		}

		else if (primeInt == 203){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = ""; 
			Char3name.text = "???";
			Char3speech.text = "Where did Little Joey get to?";
		}

		else if (primeInt == 204){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "???";
			Char2speech.text = "He had to go take a leak. Keep looking for the painting."; 
			Char3name.text = "";
			Char3speech.text = "";
		}

		else if (primeInt == 205){
			Char1name.text = "You";
			Char1speech.text = "These guys are sounding suspicious.";
			Char2name.text = "";
			Char3speech.text = "";
			Char3name.text = "";
			Char2speech.text = "";
		}

		else if (primeInt == 206){
			Char1name.text = "You";
			Char1speech.text = "These guys are sounding suspicious.";
			Char2name.text = "";
			Char3speech.text = "";
			Char3name.text = "";
			Char2speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene2Button.SetActive(true); //Maybe I should check out the bathroom
		}
	}

	// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = "You";
		Char1speech.text = "Hey, Rupert! Is that you?";
		Char2name.text = "";
		Char2speech.text = "";
		Char3name.text = "";
		Char3speech.text = "";
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
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
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

	public void SceneChange2a(){
		SceneManager.LoadScene("Scene2a");
	}
	public void SceneChange2b(){
		SceneManager.LoadScene("Scene2b");
	}
}