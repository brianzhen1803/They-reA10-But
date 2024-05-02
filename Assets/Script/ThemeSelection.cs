using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelection : MonoBehaviour
{
    // The toggle buttons
    public static bool toggleL = true;
    public static bool toggleS = true;
    public static bool toggleP = true;
    public static bool toggleO = true;
    public static bool toggleVG = true;
    public static bool toggleSh = true;
    public static bool toggleA = true;
    public static bool toggleMR = true;
    public static bool toggleOc = true;
    public static bool toggleIn = true;
    public static bool toggleBo = true;

    //turn on or off themes
    public void onOrOffSetL() {
        if (toggleL == true) {
            toggleL = false;
        }
        else {
            toggleL = true;
        }
        Debug.Log(toggleL);
    }
    
    public void onOrOffSetS() {
        if (toggleS == true) {
            toggleS = false;
        }
        else {
            toggleS = true;
        }
        Debug.Log(toggleS);
    }

    public void onOrOffSetP() {
        if (toggleP == true) {
            toggleP = false;
        }
        else {
            toggleP = true;
        }
        Debug.Log(toggleP);
    }

    public void onOrOffSetO() {
        if (toggleO == true) {
            toggleO = false;
        }
        else {
            toggleO = true;
        }
        Debug.Log(toggleO);
    }

    public void onOrOffSetVG() {
        if (toggleVG == true) {
            toggleVG = false;
        }
        else {
            toggleVG = true;
        }
        Debug.Log(toggleVG);
    }

    public void onOrOffSetSh() {
        if (toggleSh == true) {
            toggleSh = false;
        }
        else {
            toggleSh = true;
        }
        Debug.Log(toggleSh);
    }

    public void onOrOffSetA() {
        if (toggleA == true) {
            toggleA = false;
        }
        else {
            toggleA = true;
        }
        Debug.Log(toggleA);
    }

    public void onOrOffSetMR() {
        if (toggleMR == true) {
            toggleMR = false;
        }
        else {
            toggleMR = true;
        }
        Debug.Log(toggleMR);
    }

    public void onOrOffSetOc() {
        if (toggleOc == true) {
            toggleOc = false;
        }
        else {
            toggleOc = true;
        }
        Debug.Log(toggleOc);
    }

    public void onOrOffSetIn() {
        if (toggleIn == true) {
            toggleIn = false;
        }
        else {
            toggleIn = true;
        }
        Debug.Log(toggleIn);
    }

    public void onOrOffSetBo() {
        if (toggleBo == true) {
            toggleBo = false;
        }
        else {
            toggleBo = true;
        }
        Debug.Log(toggleBo);
    }
}
