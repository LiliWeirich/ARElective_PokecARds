using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kwaksAnimation : MonoBehaviour
{
    public Animator kwaksAnimator;
    public GameObject kwaksModel;

    // Start is called before the first frame update
    void Start()
    {
        //kwaksAnimator = GetComponent<Animator>();
        kwaksModel.GetComponent<Animator>().Play("Armature|Idle");
    }

   
    /*
    // Update is called once per frame
    void Update()
    {
        if (kwaksAnimator != null)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                kwaksAnimator.SetTrigger("trHappy");
            }
        }
    }
   */

    public void OnButtonClick()
    {
       kwaksModel.GetComponent<Animator>().Play("Armature|Happy");
    }
    
}
