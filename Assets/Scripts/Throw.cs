using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    private GameObject Berry;
 
    float startTime, endTime, swipeDistance, swipeTime;
    private Vector2 startPos;
    private Vector2 endPos;
 
    public float MinSwipDist = 0;
    private float BerryVelocity = 0;
    private float BerrySpeed = 0;
    public float MaxBerrySpeed = 350;
    private Vector3 angle;
 
    private bool thrown, holding;
    private Vector3 newPosition;
    Rigidbody rb;
 
    // Start is called before the first frame update
    void Start()
    {
        setupBerry();
    }
 
    void setupBerry()
    {
        GameObject _berry = GameObject.FindGameObjectWithTag("Berry");
        Berry = _berry;
        rb = Berry.GetComponent<Rigidbody>();
        ResetBerry();
    }
 
    void ResetBerry()
    {
        angle = Vector3.zero;
        endPos = Vector2.zero;
        startPos = Vector2.zero;
       BerrySpeed = 0;
        startTime = 0;
        endTime = 0;
        swipeDistance = 0;
        swipeTime = 0;
        thrown = holding = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        Berry.transform.position = transform.position;
    }
 
    void PickupBerry()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane * 5f;
        newPosition = Camera.main.ScreenToWorldPoint(mousePos);
        Berry.transform.localPosition = Vector3.Lerp(Berry.transform.localPosition, newPosition, 80f * Time.deltaTime);
    }
 
    private void Update()
    {
        if(holding)
            PickupBerry();
 
        if (thrown)
            return;
 
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _hit;
 
            if(Physics.Raycast(ray, out _hit, 100f))
            {
                if(_hit.transform == Berry.transform)
                {
                    startTime = Time.time;
                    startPos = Input.mousePosition;
                    holding = true;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endTime = Time.time;
            endPos = Input.mousePosition;
            swipeDistance = (endPos - startPos).magnitude;
            swipeTime = endTime - startTime;
 
            if (swipeTime < 0.5f && swipeDistance > 30f)
            {
                //throw berry
                CalSpeed();
                CalAngle();
                rb.AddForce(new Vector3((angle.x * BerrySpeed), (angle.y * BerrySpeed / 3), (angle.z * BerrySpeed) * 2));
                rb.useGravity = true;
                holding = false;
                thrown = true;
                Invoke("ResetBerry", 4f);
            }
            else
                ResetBerry();
        }
    }
 
    private void CalAngle()
    {
        angle = Camera.main.ScreenToWorldPoint(new Vector3(endPos.x, endPos.y + 50f, (Camera.main.nearClipPlane + 5)));
    }
 
    void CalSpeed()
    {
        if(swipeTime > 0)
        BerryVelocity = swipeDistance / (swipeDistance - swipeTime);
 
        BerrySpeed = BerryVelocity * 40;
 
        if(BerrySpeed <= MaxBerrySpeed)
        {
            BerrySpeed = MaxBerrySpeed;
        }
        swipeTime = 0;
    }
}

