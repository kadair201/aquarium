using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFishScript : MonoBehaviour
{
    public SettingsMenuScript settingsMenuScript;
    public AddFishScript addFishScript;

    // initialise variables that control direction of fish
    bool changeDirectionToRight = false;
    bool changeDirectionToDown = false;

    // initialise boolean for sprite flipping
    public bool flipX;

    // initialise size
    public float fishSize = 1f;
    public float bounceboye = 1f;
    public int moneyPer7Secs;

    // declare sprite renderer
    public SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer.flipX = false;
        settingsMenuScript = GameObject.Find("SettingsObject").GetComponent<SettingsMenuScript>();
        addFishScript = GameObject.Find("AddFishObject").GetComponent<AddFishScript>();
        transform.localScale = new Vector2(fishSize, fishSize);

        moneyPer7Secs = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (settingsMenuScript.resetLevel == true)
        {
            addFishScript.numberOfFish--;
            Destroy(gameObject);

            fishSize = 1f;
            transform.localScale = new Vector2(fishSize, fishSize);
        }

        // if meant to move left, move left
        if (changeDirectionToRight == false)
        {
            if (!settingsMenuScript.moustachesEnabled)
            {
                GetComponent<Animator>().Play("Bob1");
            }
            else
            {
                GetComponent<Animator>().Play("Moustache1");
            }

            float randomNum = Random.Range(0f, bounceboye);

            transform.Translate(Vector2.left * (Time.deltaTime * randomNum));

            //  move up
            if (!changeDirectionToDown)
            {
                transform.Translate(Vector2.up * (Time.deltaTime * randomNum));
            }
            else // move down
            {
                transform.Translate(Vector2.down * (Time.deltaTime * randomNum));
            }

        }
        else
        {
            if (!settingsMenuScript.moustachesEnabled)
            {
                GetComponent<Animator>().Play("Bob1");
            }
            else
            {
                GetComponent<Animator>().Play("Moustache1");
            }

            float randomNum = Random.Range(0f, bounceboye);

            transform.Translate(Vector2.right * (Time.deltaTime * randomNum));

            if (!changeDirectionToDown)
            {
                transform.Translate(Vector2.up * (Time.deltaTime * randomNum));
            }
            else
            {
                transform.Translate(Vector2.down * (Time.deltaTime * randomNum));
            }
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bonk")
        {
            if (collision.name == "BonkUpper")
            {
                changeDirectionToDown = true;
            }

            if (collision.name == "BonkLower")
            {
                changeDirectionToDown = false;
            }

            if (collision.name == "BonkLeft")
            {
                changeDirectionToRight = true;
                spriteRenderer.flipX = true;
            }

            if (collision.name == "BonkRight")
            {
                changeDirectionToRight = false;
                spriteRenderer.flipX = false;
            }
        }
    }
}
