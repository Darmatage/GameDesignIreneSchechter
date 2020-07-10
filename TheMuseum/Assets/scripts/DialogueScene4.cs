using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4 : MonoBehaviour {
	public int primeInt =1; // This integer drives game progress!
	public Text Char1name;
	public Text Char1speech;
	public Text Char2name;
	public Text Char2speech;
	public Text Char3name;
	public Text Char3speech;
	public Text Char4name;
	public Text Char4speech;
	public Text Char5name;
	public Text Char5speech;
	public GameObject dialogue;
	public GameObject ArtChar1;
	public GameObject ArtChar2;
	public GameObject ArtChar3;
	public GameObject ArtChar4;
	public GameObject ArtBG1;
	public GameObject ArtBG2;
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
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
		ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
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
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "Alarm";
			Char5speech.text = "Wee Woo Wee Woo Wee Woo!!!";
		}
		else if (primeInt ==3){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Thief 1";
			Char2speech.text = "What the heck is that sound?";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 4){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Thief 2";
			Char3speech.text = "We better find a way out and fast!";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 5){
			Char1name.text = "You";
			Char1speech.text = "Quick we gotta catch them!";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}
		else if (primeInt == 6){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "Should we try to tackle them or lock the doors so they can't escape?";
			Char5name.text = "";
			Char5speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "You take the big one, I'll take the small one.";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 101){
			Char1name.text = "You";
			Char1speech.text = "How come I always get the big one?";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 102){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "No time to argue! YEahahhhhh!";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 103){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Thief 1";
			Char2speech.text = "What the--?";  
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 104){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";  
			Char3name.text = "Thief 2";
			Char3speech.text = "Ack my spleen!";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 105){
			Char1name.text = "You";
			Char1speech.text = "I have this one pinned. What can I tie him with?";
			Char2name.text = "";
			Char2speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 106)
		{
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "Here is some rope!";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 107)
		{
			Char1name.text = "You";
			Char1speech.text = "Why do you have rope?";
			Char2name.text = "";
			Char2speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 108){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "Are you complaining?";
			Char5name.text = "";
			Char5speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true); // I better go check out the bathroom
		}



		else if (primeInt == 200){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "Done!";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 201){
			ArtBG1.SetActive(false);
			ArtBG2.SetActive(true);
			ArtChar3.SetActive(false);
			Char1name.text = "You";
			Char1speech.text = "Okay mine are locked!";
			Char2name.text = "";
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 202){
			ArtChar4.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "Rupert";
			Char4speech.text = "Mine too! Uh oh...";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 203){
			Char1name.text = "You";
			Char1speech.text = "Rupert, you okay pal?";
			Char2name.text = "";
			Char2speech.text = ""; 
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 204){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Thief 1";
			Char2speech.text = "Worry about yourself pal!"; 
			Char3name.text = "";
			Char3speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 205){
			Char1name.text = "You";
			Char1speech.text = "We locked all the doors! You're stuck here!";
			Char2name.text = "";
			Char3speech.text = "";
			Char3name.text = "";
			Char2speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
		}

		else if (primeInt == 206){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Thief 1";
			Char3speech.text = "Ever heard of air vents?";
			Char3name.text = "";
			Char2speech.text = "";
			Char4name.text = "";
			Char4speech.text = "";
			Char5name.text = "";
			Char5speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene2Button.SetActive(true); //Maybe I should check out the bathroom
		}
	}

	// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = "You";
		Char1speech.text = "They're lost in here. Let's jump them!";
		Char2name.text = "";
		Char2speech.text = "";
		Char3name.text = "";
		Char3speech.text = "";
		Char4name.text = "";
		Char4speech.text = "";
		Char5name.text = "";
		Char5speech.text = "";
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
	public void Choice1bFunct(){
		Char1name.text = "You";
		Char1speech.text = "You take the South entrances. I'll take the West and Main.";
		Char2name.text = "";
		Char2speech.text = "";
		Char3name.text = "";
		Char3speech.text = "";
		Char4name.text = "";
		Char4speech.text = "";
		Char5name.text = "";
		Char5speech.text = "";
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