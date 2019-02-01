using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddFishScript : MonoBehaviour {

    public bool menuOpen = false;
    public int numberOfFish;

    public SettingsMenuScript settingsMenuScript;
    public TutorialScript tutorialScript;

    public GameObject addMenu;
    public GameObject addFishButton;

    public AudioClip buttonClick;

    

    // Use this for initialization
    void Start ()
    {
        addMenu.SetActive(false);
        addFishButton.SetActive(false);
        numberOfFish = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!(tutorialScript.zoomInActive))
        {
            addFishButton.SetActive(true);
            settingsMenuScript.settingsButton.SetActive(true);
        }
	}

    public void OpenAddMenu()
    {
        if (settingsMenuScript.settingsMenuOpen == true)
        {
            settingsMenuScript.settingsMenu.SetActive(false);
            settingsMenuScript.settingsMenuOpen = false;
        }

        GetComponent<AudioSource>().PlayOneShot(buttonClick);

        if (menuOpen == false)
        {
            addMenu.SetActive(true);
            menuOpen = true;
        }
        else
        {
            addMenu.SetActive(false);
            menuOpen = false;
        }
    }

}
