using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject redFishPrefab;
    public GameObject blueFishPrefab;
    public GameObject greenFishPrefab;
    public GameObject orangeFishPrefab;
    public GameObject foodPrefab;

    public ChooseSpawnFishScript chooseSpawnFishScript;
    public AddFishScript addFishScript;

    // remember to apply this to fish other than red
    public List<GameObject> fish = new List<GameObject>();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void SpawnRedFish()
    {
        GameObject Fish1 = (GameObject)Instantiate(redFishPrefab, transform.position, Quaternion.identity);
        Fish1.name = "RedFish";
        Debug.Log(gameObject.name);
        addFishScript.numberOfFish++;
        fish.Add(Fish1);
    }

    public void SpawnBlueFish()
    {
        if (gameObject.name == "SP" + chooseSpawnFishScript.spawnPointNumber.ToString())
        {
            GameObject Fish2 = (GameObject)Instantiate(blueFishPrefab, transform.position, Quaternion.identity);
            Fish2.name = "BlueFish";
            Debug.Log("Fish 2 spawned");
            addFishScript.numberOfFish++;
        }
    }

    public void SpawnGreenFish()
    {
        if (gameObject.name == "SP" + chooseSpawnFishScript.spawnPointNumber.ToString())
        {
            GameObject Fish3 = (GameObject)Instantiate(greenFishPrefab, transform.position, Quaternion.identity);
            Fish3.name = "GreenFish";
            addFishScript.numberOfFish++;
        }
    }

    public void SpawnOrangeFish()
    {
        if (gameObject.name == "SP" + chooseSpawnFishScript.spawnPointNumber.ToString())
        {
            GameObject Fish4 = (GameObject)Instantiate(orangeFishPrefab, transform.position, Quaternion.identity);
            Fish4.name = "OrangeFish";
            addFishScript.numberOfFish++;
        }
    }

    public void SpawnFishFood()
    {
        GameObject Food = (GameObject)Instantiate(foodPrefab, transform.position, Quaternion.identity);
        Food.name = "Food";
    }
}
