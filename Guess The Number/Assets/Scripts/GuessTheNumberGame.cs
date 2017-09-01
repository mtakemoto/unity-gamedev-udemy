using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GuessTheNumberGame : MonoBehaviour {

    // Public fields will populate in the Unity UI for binding
    // Binding done through drag and drop
    public InputField input;
    public Text infoText;

    private int randomNumber;
    private int userGuess;

	// Use this for initialization
	void Start () {
        randomNumber = Random.Range(0, 100);
	}

    public void CheckGuess() {
        userGuess = int.Parse(input.text);
        if (userGuess == randomNumber) {
            infoText.text = "Correct Number!  You're a wizard, Harry!";
        }
        else if (userGuess > randomNumber) {
            infoText.text = "Your number is greater than the guess number";
        }
        else if (userGuess < randomNumber) {
            infoText.text = "Your number is lower than the guess number";
        }
        input.text = "";
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
