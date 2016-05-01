using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess;
    bool reset = true;
    int maxGuess = 10;
    System.Random r = new System.Random();

    public Text text;
    // Use this for initialization
    void Start () {
        StartGame();
	}

    void StartGame() {
        print("========================================");
        print("Welcome to Number wizard!");
        print("Pick a number in your head but don't tell me.");

        print("Max number is " + max);
        print("Min number is " + min);
        print("Initial Guess is " + guess);
        max++;
    }

    void ResetGame() {
        Debug.ClearDeveloperConsole();
        max = 1000;
        min = 1;
        NextGuess();
    }

    void NextGuess() {
        guess = r.Next(min, max + 1);
        text.text = guess.ToString();
        maxGuess -= 1;
        if(maxGuess == 0) {
            SceneManager.LoadScene("Win");
        }
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

	// Update is called once per frame
	void Update () {
        if (reset == true) {
            ResetGame();
            reset = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();        
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won");
            ResetGame();
            StartGame();
        }
    }

}
