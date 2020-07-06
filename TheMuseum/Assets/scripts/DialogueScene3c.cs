using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3c : MonoBehaviour
{
	public int primeInt = 1; // This integer drives game progress!
	public Text Char1name;
	public Text Char1speech;
	public Text Char2name;
	public Text Char2speech;
	public Text Char3name;
	public Text Char3speech;
	public GameObject dialogue;
	public GameObject ArtChar1;
	public GameObject ArtChar2;
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
		ArtChar2.SetActive(false);
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
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "Oh thank goodness you're here. The thieves are right over there.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 3)
		{
			Char1name.text = "You";
			Char1speech.text = "We better stay quiet.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 4)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "It might be better if we trigger the alarm. It could scare them which would give us a perfect opportunity to catch them.";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			Choice1a.SetActive(true); // function Choice1aFunct()
			Choice1b.SetActive(true); // function Choice1bFunct()

		}

		// ENCOUNTER AFTER CHOICE #1
		else if (primeInt == 100)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "Alright, the alarm is right over there.";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 101)
		{
			Char1name.text = "You";
			Char1speech.text = "I thought you were going to pull it.";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 102)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "You're the sneaky one.";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 103)
		{
			Char1name.text = "You";
			Char1speech.text = "Watch my back";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 104)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "With what? My mop? Just pull it already!";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true); // I better go check out the bathroom
		}


		else if (primeInt == 200)
		{
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "Coward!";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 201)
		{
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Thieves";
			Char3speech.text = "Who's there???";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 202)
		{
			ArtChar1.SetActive(true);
			ArtChar2.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Rupert";
			Char2speech.text = "Oh crud.";
			Char3name.text = "";
			Char3speech.text = "";
			nextButton.SetActive(true);
			allowSpace = true;
		}
		else if (primeInt == 104)
		{
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Thieves";
			Char3speech.text = "Oh. You again. And a friend. Nice to see you both.";
			nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true); // I better go check out the bathroom
		}
	}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct()
	{
		Char1name.text = "You";
		Char1speech.text = "Let's go for it!";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 99;
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
	public void Choice1bFunct()
	{
		Char1name.text = "You";
		Char1speech.text = "This is above my pay grade. I'm getting out of here.";
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

	public void SceneChange2a()
	{
		SceneManager.LoadScene("Scene3b");
	}
	public void SceneChange2b()
	{
		SceneManager.LoadScene("Scene3c");
	}
}