using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManipulator : MonoBehaviour
{
    private GameObject selectedObject;

    private void Start()
    {
        // Initially, no object is selected
        selectedObject = null;
    }

    private void Update()
    {
        // Check if there is a selected object
        if (selectedObject != null)
        {
            // Perform any necessary updates or checks on the selected object
            // For example, you can update its position, rotation, or scale based on user input
        }
    }

    public void SelectObject(GameObject obj)
    {
        // Deselect the currently selected object (if any)
        DeselectObject();

        // Select the new object
        selectedObject = obj;
    }

    public void DeselectObject()
    {
        // Deselect the currently selected object (if any)
        selectedObject = null;
    }
}
