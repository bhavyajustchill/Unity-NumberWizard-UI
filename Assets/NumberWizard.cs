using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    int min, max, guess, maxGussesAllowed = 15;
    public Text text;
    // Start is called before the first frame update
    public void Start()
    {
        print("Welcome to Number Wizard!");
        StartGame();
    }

    public void StartGame()
    {
        min = 1;
        max = 1000;
        NextGuess();
    }

    //[System.Obsolete]
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    //[System.Obsolete]
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    //[System.Obsolete]
    public void NextGuess()
    {
        guess = Random.Range(min,max+1);
        text.text = guess.ToString();
        maxGussesAllowed--;
        if (maxGussesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
