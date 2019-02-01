using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishFoodScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Animator>().Play("Float");
        transform.Translate(Vector2.down * (Time.deltaTime / 2));
	}
}
