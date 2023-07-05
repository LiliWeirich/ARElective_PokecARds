using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    private bool isSelected = false;
     int movementSpeed;

    private void Update()
    {
        if (isSelected)
        {
            // Get input movement vector
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

            // Move the object based on input
            transform.position += movement * Time.deltaTime * movementSpeed;
        }
    }

    private void OnMouseDown()
    {
        // Toggle selection state
        isSelected = !isSelected;
    }
}
