using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    /*private bool isSelected = false;
    private Vector3 touchOffset;

    void Update()
    {
        if (isSelected)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Moved)
                {
                    // Calculate the touch position in world space
                    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, Camera.main.nearClipPlane));

                    // Apply any necessary offset to align the touch with the object
                    Vector3 targetPosition = touchPosition - touchOffset;

                    // Update the object's position
                    transform.position = targetPosition;
                }
            }
        }
    }

    public void SetSelected(bool selected)
    {
        isSelected = selected;

        if (isSelected)
        {
            // Calculate the offset between the touch position and the object's position
            Vector3 touchPosition = Camera.main.WorldToScreenPoint(transform.position);
            touchOffset = new Vector3(Input.mousePosition.x, Input.mousePosition.y, touchPosition.z) - touchPosition;
        }
    }
    */
}
