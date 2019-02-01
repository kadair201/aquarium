using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoneyScript : MonoBehaviour
{
    public int totalMoney = 0;
    
    public Text coinsText;
    public AddFishScript addFishScript;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddMoney());

        totalMoney = 30;
        coinsText.text = "Coins: " + totalMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AddMoney()
    {
        yield return new WaitForSeconds(6);
        Add();
    }

    void Add()
    {
        //totalMoney += fishMoneyPer7;
        coinsText.text = "Coins: " + totalMoney.ToString();

        StartCoroutine(AddMoney());
    }
}
