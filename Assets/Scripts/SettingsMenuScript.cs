using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour {

    public bool settingsMenuOpen = false;
    public bool resetLevel = false;
    public bool moustachesEnabled = false;

    public Button moustacheButton;

    public Sprite moustacheOnSprite;
    public Sprite moustacheOffSprite;

    public AddFishScript addFishScript;

    public GameObject settingsMenu;
    public GameObject settingsButton;

    public AudioClip buttonClick;

    // Use this for initialization
    void Start () {
        settingsMenu.SetActive(false);
        addFishScript.menuOpen = false;
        settingsButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OpenSettingsMenu()
    {
        if (addFishScript.menuOpen == true)
        {
            addFishScript.addMenu.SetActive(false);
            addFishScript.menuOpen = false;
        }

        GetComponent<AudioSource>().PlayOneShot(buttonClick);

        if (settingsMenuOpen == false)
        {
            settingsMenu.SetActive(true);
            settingsMenuOpen = true;
        }
        else
        {
            settingsMenu.SetActive(false);
            settingsMenuOpen = false;
        }

        if (addFishScript.numberOfFish <= 0)
        {
            resetLevel = false;
        }
    }

    public void ResetLevel()
    {
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        if (addFishScript.numberOfFish > 0)
        {
            resetLevel = true;
            StartCoroutine(StopReset());
        }
    }

    IEnumerator StopReset()
    {
        yield return new WaitForSeconds(0.5f);
        resetLevel = false;
        addFishScript.numberOfFish = 0;
    }

    public void MoustacheButton()
    {
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        if (moustacheButton.image.sprite == moustacheOnSprite)
        {
            moustacheButton.image.sprite = moustacheOffSprite;
            moustachesEnabled = false;
        }
        else
        {
            moustacheButton.image.sprite = moustacheOnSprite;
            moustachesEnabled = true;
        }
        
    }
}
