using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3 : MonoBehaviour
{
	public int primeInt = 1; // This integer drives game progress!
	public Text Char1name;
	public Text Char1speech;
	public Text Char2name;
	public Text Char2speech;
	public GameObject dialogue;
	public GameObject ArtChar1;
	public GameObject ArtChar2;
	public GameObject ArtChar3;
	public GameObject ArtBG1;
	public GameObject Choice1a;
	public GameObject Choice1b;
	public GameObject Choice1c;
	public GameObject nextButton;
	public GameObject NextScene1Button;
	public GameObject NextScene2Button;
	//public GameObject gameHandler;
	//public AudioSource audioSource;
	private bool allowSpace = true;

	void Start()
	{         // initial visibility settings
		dialogue.SetActive(false);
		ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false);
		nextButton.SetActive(true);
	}

	void Update()
	{         // use spacebar as Next button
		if (allowSpace == true)
		{
			if (Input.GetKeyDown("space"))
			{
				talking();
			}
		}

	}

	public void talking()
	{         // main story function. Players hit next to progress to next int
		primeInt = primeInt + 1;
		Debug.Log("primeInt = " + primeInt);

		if (primeInt == 1)
		{
			// AudioSource.Play();
		}
		else if (primeInt == 2)
		{
			dialogue.SetActive(true);
			ArtChar3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "Boy";
			Char2name.text = "Uh hi?";
			Char2speech.text = "";
	
		}
		else if (primeInt == 3)
		{
			Char1name.text = "You";
			Char1speech.text = "Who are you supposed to be?";
			Char2name.text = "";
			Char2speech.text = "";
	
		}
		else if (primeInt == 4)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Boy";
			Char2speech.text = "I'm the new uh curator. Yeah, the curator of the new exhibit.";

			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()
			Choice1c.SetActive(true);
		}
		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100)
		{
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Boy";
			Char2speech.text = "I need backup!";
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true);

		}

		else if (primeInt == 300)
		{
			ArtChar3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Boy";
			Char2speech.text = "Look, I'm here with some people to steal the new Da Vinci painting.";

		}
		else if (primeInt == 301)
		{
			ArtChar3.SetActive(true);
			Char1name.text = "You";
			Char1speech.text = "Well if you help me catch them I can let you go.";
			Char2name.text = "";
			Char2speech.text = "";
			NextScene1Button.SetActive(true);

		}

		nextButton.SetActive(false);
			allowSpace = false;
			NextScene2Button.SetActive(true); //Maybe I should check out the bathroom
		}
	}

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
public void Choice1aFunct()
{
	Char1name.text = "You";
	Char1speech.text = "I know the new curator and you're definitely not her.";
	Char2name.text = "";
	Char2speech.text = "";
	primeInt = 99;
	Choice1a.SetActive(false);
	Choice1b.SetActive(false);
	Choice1c.SetActive(false);
	nextButton.SetActive(true);
	allowSpace = true;
}
public void Choice1bFunct()
{
	Char1name.text = "You";
	Char1speech.text = "This guy is clearly sketchy. I should find Rupert.";
	Char2name.text = "";
	Char2speech.text = "";
	primeInt = 199;
	Choice1a.SetActive(false);
	Choice1b.SetActive(false);
	Choice1c.SetActive(false);
	nextButton.SetActive(false);
	allowSpace = false;
	NextScene2Button.SetActive(true);
}

    public void SceneChangeEndLose()
	{
		SceneManager.LoadScene("EndLose");
	}
	public void SceneChangeScene3()
	{
		SceneManager.LoadScene("Scene3");
	}
}