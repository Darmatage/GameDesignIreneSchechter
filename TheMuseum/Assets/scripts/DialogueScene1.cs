﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 


public class DialogueScene1 : MonoBehaviour { 
	public int primeInt = 0; // This integer drives game progress!
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

	void Start(){
		dialogue.SetActive(false);
		ArtChar1.SetActive(false); 
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false); 
		nextButton.SetActive(true);

		Screen.SetResolution(1000, 720, true);
	}

	public void talking(){ 
		primeInt = primeInt + 1;
		// Simple "follow" story units: player hits "Next" button to show each unit
		if (primeInt == 1){
			//audioSource.Play();
		}
		if (primeInt == 2){ 
			ArtChar1.SetActive(true); 
			dialogue.SetActive(true); 
			Char1name.text = "You"; 
			Char1speech.text = "Hey Rupert. Heard anything about the new exhibit?";
			Char2name.text = ""; 
			Char2speech.text = "";
		}
		else if (primeInt ==3){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "Rupert"; 
			Char2speech.text = "Seems like its some never before heard of Da Vinci painting. Was told to be careful around it. It's currently in Gallery 3. Where are you gonna start your security shift?";
			//gameHandler.AddPlayerStat(1);
		} 
		else if (primeInt == 4){
			Char1name.text = "You"; 
			Char1speech.text = "I'm gonna start with Gallery 1, but I'll keep an eye out for that new painting.";
			Char2name.text = ""; 
			Char2speech.text = "";
		} 
		else if (primeInt == 5){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "Rupert"; 
			Char2speech.text = "Well I'll be around cleaning. Let me know if you need anything."; 
			//gameHandler.AddPlayerStat(1);
		} 
		else if (primeInt == 6){
			Char1name.text = "Jeda"; 
			Char1speech.text = "I am searching for a fugitive. Ragu Fahn.";
			Char2name.text = ""; 
			Char2speech.text = "";
		} 
		else if (primeInt ==7){
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "You"; 
			Char2speech.text = "Why do you think I know anything?";
		} 
		else if (primeInt == 8){
			Char1name.text = "Jeda"; 
			Char1speech.text = "Do not play the stupid. You will take me to him.";
			Char2name.text = ""; 
			Char2speech.text = "";
			// Turn off "Next" button, turn on "Choice" buttons
			nextButton.SetActive(false);
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
		} 
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100){
			Char1name.text = "Jeda"; 
			Char1speech.text = "Then you are no use to me, and must be silenced.";
			Char2name.text = ""; 
			Char2speech.text = "";

		} 
		else if (primeInt == 101){ 
			Char1name.text = "Jeda"; 
			Char1speech.text = "Come back here! Do not think you can hide frorm me!";
			Char2name.text = ""; 
			Char2speech.text = "";
			nextButton.SetActive(false); 
			NextScene1Button.SetActive(true);
		} 
		else if (primeInt == 200){
			Char1name.text = "Jeda"; 
			Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
			Char2name.text = ""; 
			Char2speech.text = "";

		} 
		else if (primeInt == 201){ 
			Char1name.text = ""; 
			Char1speech.text = "";
			Char2name.text = "You"; 
			Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
			nextButton.SetActive(false); 
			NextScene2Button.SetActive(true);
		} 
	} 

	// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
		Char1name.text = ""; 
		Char1speech.text = "";
		Char2name.text = "You"; 
		Char2speech.text = "I don't know what you're talking about!";
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
	} 
	public void Choice1bFunct(){ 
		Char1name.text = ""; 
		Char1speech.text = ""; 
		Char2name.text = "You"; 
		Char2speech.text = "Sure, anything you want... just lay off the club.";
		primeInt = 199;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
	}

	public void SceneChange2a(){
		SceneManager.LoadScene("Scene2a");
	} 
	public void SceneChange2b(){ 
		SceneManager.LoadScene("Scene2b");
	}
}