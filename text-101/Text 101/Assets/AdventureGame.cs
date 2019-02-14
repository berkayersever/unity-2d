using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    //int[] oddNumbers = { 1, 3, 5, 7, 9 };
    //string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();
        //Debug.Log(oddNumbers[3]);
        //Debug.Log(daysOfTheWeek[1]);
        // int sizeOfArray = oddNumbers.Length;
        //for (int i = 0; i < oddNumbers.Length; i++) {
        //    Debug.Log(oddNumbers[i]);
        //}
        //for (int i = 0; i < daysOfTheWeek.Length; i++)
        //{
        //    Debug.Log(daysOfTheWeek[i]);
        //}
    }
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            state = nextStates[0];
        }
    }
}
