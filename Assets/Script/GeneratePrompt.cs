using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;

public class GeneratePrompt : MonoBehaviour
{
    // text for prompt and rating with list of ratings to randomly input
    public Text rating;
    public Text prompt;

    public ThemeSelection theme;

    public string[] ratingLists = {"1", "2","2", "3", "3", "3", "4", "4", "4", "4", "5", "5", "5", "5", "5", "6", 
    "6", "6", "6", "6", "6", "6", "6", "6", "7", "7", "7", "7", "7", "7", "7", "7", "7", "8", "8", "8", "9", "9", "9", "10", "10", "10"};

    // Start is called before the first frame update
    void Start() {
        rating.text = ratingLists[Random.Range(0,41)];
        prompt.text = "This is a Prompt before";
    }

    public void changeRating()
    {
        rating.text = ratingLists[Random.Range(0,41)];
    }

    public void changePrompt() 
    {
        prompt.text = "This is a Prompt after";
    }
}
