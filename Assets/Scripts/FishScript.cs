using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
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
    public float bounceboye = 500f;
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

        if (gameObject.name == "RedFish")
        {
            moneyPer7Secs = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (settingsMenuScript.resetLevel == true)
        {
            if (gameObject.name == "RedFish" || gameObject.name == "BlueFish" || gameObject.name == "GreenFish" || gameObject.name == "OrangeFish")
            {
                addFishScript.numberOfFish--;
                Destroy(gameObject);
            }

            fishSize = 1f;
            transform.localScale = new Vector2(fishSize, fishSize);
            
        } 

        

        // if meant to move left, move left
        if (changeDirectionToRight == false)
        {
            // play correct animation according to fish name
            if (gameObject.name == "RedFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache");
                }
                
            }

            if (gameObject.name == "BlueFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob2");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache2");
                }
            }

            if (gameObject.name == "GreenFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob3");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache3");
                }
            }

            if (gameObject.name == "OrangeFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob4");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache4");
                }
            }

            transform.Translate(Vector2.left * Time.deltaTime);

            // dont fucking forget this is here >:(
            float randomNum = Random.Range(0f, bounceboye);

            //  move up
            if (changeDirectionToDown == false)
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
            // play correct animation according to fish name, test test test
        
            if (gameObject.name == "RedFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache");
                }

            }

            if (gameObject.name == "BlueFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob2");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache2");
                }
            }

            if (gameObject.name == "GreenFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob3");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache3");
                }
            }

            if (gameObject.name == "OrangeFish")
            {
                if (settingsMenuScript.moustachesEnabled == false)
                {
                    GetComponent<Animator>().Play("Bob4");
                }
                else
                {
                    GetComponent<Animator>().Play("Moustache4");
                }
            }

            float randomNum = Random.Range(0f, bounceboye);

            transform.Translate(Vector2.right * Time.deltaTime);

            if (changeDirectionToDown == false)
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
