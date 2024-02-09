using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tastiera : MonoBehaviour
{

    TouchScreenKeyboard clavier;
    public TextMeshProUGUI txt;

    // Start is called before the first frame update
    public void OpenKeyboard()
    {
        clavier = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
