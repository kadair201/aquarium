using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    public AudioClip buttonClick;
    public Button goButton;

    IEnumerator DelayLoadMainMenu()
    {
        goButton.GetComponent<Animator>().Play("ButtonClicked");
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Scene1");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadMainMenu()
    {
        StartCoroutine(DelayLoadMainMenu());
    }
}
