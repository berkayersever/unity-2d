using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int min;
    int max;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
	}

    void StartGame () {
        min = 1;
        max = 1000;
        guess = 500;
        
        // print("Welcome to the Number Wizard");
        Debug.Log("Welcome to the Number Wizard!");
        Debug.Log("Pick a number and don't tell me what it is.");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {		
        if (Input.GetKeyDown(KeyCode.UpArrow)) {            // Detect when the up arrow key is pressed down
            // Debug.Log("Up Arrow key was pressed.");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {     // Detect when the down arrow key is pressed down
            // Debug.Log("Down Arrow key was pressed.");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {        // Detect when the up enter key is pressed down
            Debug.Log("BAZINGA!");
            StartGame();
        }
    }

    void NextGuess () {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess + " ?");
    }

}
