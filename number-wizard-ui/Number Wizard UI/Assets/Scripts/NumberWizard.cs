using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int min;
    [SerializeField] int max;
    int guess;

	// Use this for initialization
	void Start () {
        StartGame();
	}

    void StartGame () {
        min = 1;
        max = 1000;
        guess = 500;
        
        max = max + 1;
    }

    public void OnPressHigher() {
        min = guess;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess;
        NextGuess();
    }

    // Update is called once per frame
    void Update () {		
        if (Input.GetKeyDown(KeyCode.UpArrow)) {            // Detect when the up arrow key is pressed down
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {     // Detect when the down arrow key is pressed down
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) {        // Detect when the up enter key is pressed down
            StartGame();
        }
    }

    void NextGuess () {
        guess = (max + min) / 2;
    }

}
