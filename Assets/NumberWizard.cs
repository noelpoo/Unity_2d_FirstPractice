using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update

    //int age = 20;
    //float height = 1.8f;
    //bool isAlive = true;

    int max;
    int min;
    int guess;

    void Start()
    {
        this.StartGame();
    }


    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("welcome to NumberWizard");
        Debug.Log("Pick a number, don't tell me what it is");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("the lowest number you can pick is " + min);
        Debug.Log("Tell me if you number is above or below " + guess);
        Debug.Log("up = higher, down = lower, enter = correct \n");
        max++;
        min--;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            this.NextGuess();

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            this.NextGuess();

        }  else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("your number is: " + guess + ", press enter to restart game.");
            if (Input.GetKeyDown(KeyCode.Return))
            {
                this.StartGame();
            }
        }
    }

    void NextGuess()
    {
        guess = this.CalcAvg(min, max);
        Debug.Log("is your number higher or lower than " + guess);
    }

    int CalcAvg(int a, int b)
    {
        return (a + b) / 2;
    }
}
