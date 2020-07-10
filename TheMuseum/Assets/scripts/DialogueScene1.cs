using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 


public class DialogueScene1 : MonoBehaviour { 
	public int primeInt = 1; // This integer drives game progress!
	public GameObject textTitle1; 
	public GameObject textTitle2; 
	public Text Char1name; 
	public Text Char1speech;
	public Text Char2name; 
	public Text Char2speech;
	public GameObject dialogue; 
	public GameObject ArtChar1; 
	public GameObject ArtChar2; 
	public GameObject ArtChar3; 
	public GameObject ArtChar4; 
	public GameObject ArtChar5; 
	public GameObject ArtChar6; 
	public GameObject ArtBG1; 
	public GameObject Choice1a; 
	public GameObject Choice1b; 
	public GameObject nextButton; 
	public GameObject NextScene1Button;
	public GameObject NextScene2Button; 
	//public GameObject gameHandler; 
	//public AudioSource audioSource; 
	private bool allowSpace = true;

	void Start(){
		textTitle1.SetActive(true);
		textTitle2.SetActive(false);
		dialogue.SetActive(false);
		ArtChar1.SetActive(false); 
		ArtChar2.SetActive(false); 
		ArtChar3.SetActive(false); 
		ArtChar4.SetActive(false); 
		ArtChar5.SetActive(false); 
		ArtChar6.SetActive(false); 
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false); 
		nextButton.SetActive(true);

		Screen.SetResolution(1000, 720, true);
	}

	void Update(){         // use spacebar as Next button
		if (allowSpace == true){
			if (Input.GetKeyDown("space")){
				talking();
			}
		}
	}

	public void talking(){ 
		primeInt = primeInt + 1;
		// Simple "follow" story units: player hits "Next" button to show each unit
		if (primeInt == 1){
			textTitle1.SetActive(false);
			textTitle2.SetActive(true);
			//audioSource.Play();
		}
		if (primeInt == 2){ 
			textTitle2.SetActive(false);
			dialogue.SetActive(true); 
			Char1name.text = "You"; 
			Char1speech.text = "Hey Rupert. Heard anything about the new exhibit?";
			Char2name.text = ""; 
			Char2speech.text = "";
		}
		else if (primeInt ==3){
			ArtChar4.SetActive(true); 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "Rupert"; 
			Char2speech.text = "Seems like it's some never-before-heard-of Da Vinci painting. Was told to be careful around it.";
			//gameHandler.AddPlayerStat(1);
		} 

		else if (primeInt == 4){
			Char1name.text = "You"; 
			Char1speech.text = "Which gallery is it in?";
			Char2name.text = ""; 
			Char2speech.text = "";
		} 

		else if (primeInt ==5){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "Rupert"; 
			Char2speech.text = "It's currently in Gallery 3. Where are you gonna start your security shift?";
			//gameHandler.AddPlayerStat(1);
		} 

		else if (primeInt == 6){
			Char1name.text = "You"; 
			Char1speech.text = "I'm gonna start with Gallery 1, but I'll keep an eye out for that new painting.";
			Char2name.text = ""; 
			Char2speech.text = "";
		} 
		else if (primeInt == 7){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "Rupert"; 
			Char2speech.text = "Well I'll be around cleaning. Let me know if you need anything."; 
			//gameHandler.AddPlayerStat(1);
		} 

		else if (primeInt == 8){
			dialogue.SetActive(false); 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = ""; 
			Char2speech.text = ""; 
			//gameHandler.AddPlayerStat(1);
			allowSpace = false;
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true);
		} 

	}


			
	public void SceneChange2(){
		SceneManager.LoadScene("Scene2");
	} 

}