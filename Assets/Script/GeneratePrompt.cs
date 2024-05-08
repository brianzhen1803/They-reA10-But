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

    public var themeNum = newList<dynamic>();

    public string[][] allPrompts;

    public string[] looks = {};
    public string[] social = {};
    public string[] politics = {};
    public string[] online = {};
    public string[] videogames = {};
    public string[] shows = {};
    public string[] anime = {};
    public string[] moneyrelated = {};
    public string[] occupation = {};
    public string[] intelligence = {};
    public string[] books = {};

    // Start is called before the first frame update
    void Start() {
    //set themes
    if (toggleL == true) {
        themeNum.Add(0);
    }
    if (toggleS == true) {
        themeNum.Add(1);
    }
    if (toggleP == true) {
        themeNum.Add(2);
    }
    if (toggleO == true) {
        themeNum.Add(3);
    }
    if (toggleVG == true) {
        themeNum.Add(4);
    }
    if (toggleSh == true) {
        themeNum.Add(5);
    }
    if (toggleA == true) {
        themeNum.Add(6);
    }
    if (toggleMR == true) {
        themeNum.Add(7);
    }
    if (toggleOc == true) {
        themeNum.Add(8);
    }
    if (toggleIn == true) {
        themeNum.Add(9);
    }
    if (toggleBo == true) {
        themeNum.Add(10);
    }

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
