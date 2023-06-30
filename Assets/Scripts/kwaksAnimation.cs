using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kwaksAnimation : MonoBehaviour
{
    /*private Animator kwaksAnimator;
    // Start is called before the first frame update
    void Start()
    {
        kwaksAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (kwaksAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                kwaksAnimation.SetTrigger("trHappy");
            }
        }
    }
    */

    public GameObject kwaksModel; 

    public void OnButtonClick()
    {
       kwaksModel.GetComponent<Animator>().Play("Armature|Happy");
    }
}
