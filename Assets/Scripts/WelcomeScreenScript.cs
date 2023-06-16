//================================================================
// Darmstadt University of Applied Sciences, Expanded Realities
// Course: Augmented Reality - Getting started in AR Foundation (Robin Bittlinger, Sebastian Schuchmann)
// Script by:    Lili Weirich (769701)
// Last changed: 16-06-23
//================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeScreenScript : MonoBehaviour
{
    [SerializeField] private ConfirmationWindow myWelcomeScreen;

    // Start is called before the first frame update
    void Start()
    {
        OpenComfirmationWindow("Welcome to PokécARds");
    }

    private void OpenComfirmationWindow(string message)
    {
        myWelcomeScreen.gameObject.SetActive(true);
        myWelcomeScreen.continueButton.onClick.AddListener(ButtonClicked);
        myWelcomeScreen.messageTextTitel.text = message;
        //myWelcomeScreen.messageText.text = message;
    }

    private void ButtonClicked()
    {
        myWelcomeScreen.gameObject.SetActive(false);
        Debug.Log("Button clicked");
    }
  
}
