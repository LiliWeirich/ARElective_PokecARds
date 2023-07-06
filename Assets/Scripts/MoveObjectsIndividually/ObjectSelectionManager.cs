using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelectionManager : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    SelectableObject selectableObject = hit.collider.gameObject.GetComponent<SelectableObject>();

                    if (selectableObject != null)
                    {
                        selectableObject.SetSelected(true);
                    }
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                // Release the selected object
                SelectableObject[] selectableObjects = FindObjectsOfType<SelectableObject>();

                foreach (SelectableObject obj in selectableObjects)
                {
                    obj.SetSelected(false);
                }
            }
        }
    }
}
