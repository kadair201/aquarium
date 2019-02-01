using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSpawnFishScript : MonoBehaviour
{
    public int spawnPointNumber = 0;
    public GameObject chosenSP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomNumberRed()
    {
        spawnPointNumber = Random.Range(1, 6);
        //Debug.Log("Add fish script number " + spawnPointNumber);

        chosenSP = GameObject.Find("SP" + spawnPointNumber);
        chosenSP.GetComponent<TriggerSpawnScript>().SpawnRedFish();
    }
}
