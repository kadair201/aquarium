using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMoneyScript : MonoBehaviour
{
    public int totalMoney = 0;
    int fishMoneyPer7;

    // Start is called before the first frame update
    void Start()
    {
        fishMoneyPer7 = gameObject.GetComponent<FishScript>().moneyPer7Secs;
        StartCoroutine(AddMoney());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AddMoney()
    {
        yield return new WaitForSeconds(7);
        Add();
    }

    void Add()
    {
        totalMoney += fishMoneyPer7;
        Debug.Log(totalMoney);

        StartCoroutine(AddMoney());
    }
}
