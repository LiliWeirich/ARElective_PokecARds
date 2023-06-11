//================================================================
// Darmstadt University of Applied Sciences, Expanded Realities
// Course: Augmented Reality - Getting started in AR Foundation (Robin Bittlinger, Sebastian Schuchmann)
// Script by:    Lili Weirich (769701)
// Last changed: 11-06-23
//================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private ConfirmationWindow myConfirmationWindow;
    // Start is called before the first frame update
    void Start()
    {
        OpenComfirmationWindow("Welcome bla bla bla");
    }

    private void OpenComfirmationWindow(string message)
    {
        myConfirmationWindow.gameObject.SetActive(true);
        myConfirmationWindow.yesButton.onClick.AddListener(YesClicked);
        myConfirmationWindow.messageText.text = message;
    }

    private void YesClicked()
    {
        myConfirmationWindow.gameObject.SetActive(false);
        Debug.Log("Yes clicked");
    }
  
}
