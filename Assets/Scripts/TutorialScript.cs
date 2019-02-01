using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour {

    public GameObject background;
    public GameObject tickButton;
    public GameObject skipTutorial;
    public GameObject welcomeText;

    float backgroundScale = 0.3f;
    float backgroundX = 0.0f;

    public bool zoomInActive = true;

	// Use this for initialization
	void Start ()
    {
        tickButton.SetActive(true);
        skipTutorial.SetActive(true);
        welcomeText.SetActive(true);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void ZoomInButton()
    {
        StartCoroutine(ZoomIn());
        tickButton.SetActive(false);
        skipTutorial.SetActive(false);
        welcomeText.SetActive(false);
        zoomInActive = false;
    }

    IEnumerator ZoomIn()
    {
        for (int i = 0; i < 15; i++)
        {
            yield return new WaitForSeconds(0.01f);
            backgroundScale += 0.013f;
            backgroundX -= 0.075f;
            background.transform.localScale = new Vector2(backgroundScale, backgroundScale);
            background.transform.position = new Vector2(backgroundX, 0);
        }
    }
}
