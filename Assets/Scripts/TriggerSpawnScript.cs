using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawnScript : MonoBehaviour {

    public SpawnScript spawnScript;
    public SpawnScript[] spawnScripts;
    public AudioClip buttonClick;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    

    public void SpawnRedFish()
    {
        
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        spawnScript.SpawnRedFish();
    }

    public void SpawnBlueFish()
    {
        
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        spawnScript.SpawnBlueFish();
    }

    public void SpawnGreenFish()
    {
        
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        spawnScript.SpawnGreenFish();
    }

    public void SpawnOrangeFish()
    {
        
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        spawnScript.SpawnOrangeFish();
    }

    public void SpawnFood()
    {
        GetComponent<AudioSource>().PlayOneShot(buttonClick);
        for (int i = 0; i < spawnScripts.Length; i++)
        {
            spawnScripts[i].SpawnFishFood();
        }
                
    }
}
