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
	public GameObject ArtBG1;
	public GameObject Choice1a;
	public GameObject Choice1b;
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
		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
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
			Char1name.text = "You";
			Char1speech.text = "Rupert can you pick up?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 3)
		{
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "What's up?";
		}
		else if (primeInt == 4)
		{
			Char1name.text = "You";
			Char1speech.text = "There are some sketchy looking people roaming around the musuem.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 5)
		{
			Char1name.text = "You";
			Char1speech.text = "They're trying to steal the new painting!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 6)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "We better stop them. Do you want to stay separated or meet up?";
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()

		}

		// ENCOUNTER AFTER CHOICE #1

	}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct()
	{
		Char1name.text = "You";
		Char1speech.text = "Let's stay split up. I'll go to gallery 1.";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 99;
		ArtChar1.SetActive(false);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(false);
		allowSpace = false;
		NextScene1Button.SetActive(true); // I better go check out the bathroom
	}
	public void Choice1bFunct()
	{
		Char1name.text = "You";
		Char1speech.text = "Let's meet up in gallery 2.";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 199;
		ArtChar1.SetActive(false);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(false);
		allowSpace = false;
		NextScene2Button.SetActive(true); // I better go check out the bathroom
	}

	public void SceneChange3b()
	{
		SceneManager.LoadScene("Scene3b");
	}
	public void SceneChange3c()
	{
		SceneManager.LoadScene("Scene3c");
	}
}