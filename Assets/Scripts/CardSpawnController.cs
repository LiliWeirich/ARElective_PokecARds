using UnityEngine;
using UnityEngine.UI;
using Lean.Touch;


public class CardSpawnController : MonoBehaviour
{
    public GameObject modelPrefab;
    //public Text clickHereText;

    private bool isCardFound = false;

    void Start()
    {
        // Register the event for touch input
        LeanTouch.OnFingerDown += OnFingerDown;
    }

    private void OnFingerDown(LeanFinger finger)
    {
        // Check for input only if the card is found
        if (isCardFound)
        {
            Ray ray = Camera.main.ScreenPointToRay(finger.ScreenPosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Instantiate the model prefab at the hit position and rotation
                Instantiate(modelPrefab, hit.point, Quaternion.identity);
            }
        }
        Debug.Log("finger is touching screen");
    }

}


