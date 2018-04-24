using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempratureControllerGrand : MonoBehaviour
{
    #region Ints, strings, bools, and texts

    //The 3 switches to pass the puzzle
    bool habitat1check = false;
    bool habitat2check = false;
    bool habitat3check = false;

    //The answeres input by the player into the 3 text fields
    string hab1Input;
    string hab2Input;
    string hab3Input;

    [SerializeField]
    Text hab1InputText;
    [SerializeField]
    Text hab2InputText;
    [SerializeField]
    Text hab3InputText;

    //The random number used as the answer
    int hab1Answer;
    int hab2Answer;
    int hab3Answer;

    //The answeres turned into Text types
    [SerializeField]
    Text hab1AnswerText;
    [SerializeField]
    Text hab2AnswerText;
    [SerializeField]
    Text hab3AnswerText;

    #endregion

    private void Awake() //Starts when the moduel becomes active
    {
        SetRandom();
        SendTextToBox();
    }

    private void SetRandom() //Generates the random number that will be the answers
    {
        hab1Answer = Random.Range(31, 105);
        hab2Answer = Random.Range(31, 105);
        hab3Answer = Random.Range(31, 105);
    }

    private void SendTextToBox() //Sends the new randomly generated number to its text field
    {
        hab1AnswerText.text = "Habitat 1 temp: " + hab1Answer.ToString() + "°";
        hab2AnswerText.text = "Habitat 2 temp: " + hab2Answer.ToString() + "°";
        hab3AnswerText.text = "Habitat 3 temp: " + hab3Answer.ToString() + "°";
    }

    void FixedUpdate ()
    {
        hab1Input = hab1InputText.text;
        hab2Input = hab2InputText.text;
        hab3Input = hab3InputText.text;

        //Checks the players inputs against the answers
        if (hab1Answer.ToString() == hab1Input)
            habitat1check = true;
        if (hab2Answer.ToString() == hab2Input)
            habitat2check = true;
        if (hab3Answer.ToString() == hab3Input)
            habitat3check = true;

        //Once all inputs = their answers the pannel will be won
        if (habitat1check == true && habitat2check == true && habitat3check == true)
            Debug.Log("Temp Controller Success");

        //Debugs outputing the input fields to check charecters are being read properly
        Debug.Log("Hab 1 input: " + hab1Input);
        Debug.Log("Hab 2 input: " + hab2Input);
        Debug.Log("Hab 3 input: " + hab3Input);
	}
}