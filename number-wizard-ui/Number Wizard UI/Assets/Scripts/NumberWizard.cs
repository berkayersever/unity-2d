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

    void NextGuess () {
        guess = (max + min) / 2;
    }

}
