
using UnityEngine;

public class throwberries : MonoBehaviour
{
    private GameObject Berry;

    float startTime, endTime, swipeDistance, swipeTime;
    private Vector2 startPos;
    private Vector2 endPos;

    public float MinSwipDist = 0;
    private float BerryVelocity = 0;
    private float BerrySpeed = 0;
    public float MaxBerrySpeed = 48;
    private Vector3 angle;

    private bool thrown, holding;
    private Vector3 newPosition;

    public float smooth = 0.7f;

    Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        setupBall();
    }

    void setupBall()
    {
        GameObject _berry = GameObject.FindGameObjectWithTag("Berry");
        Berry = _berry;
        rb = Berry.GetComponent<Rigidbody>();
        ResetBerry();
    }

    void  ResetBerry()
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
    }


    void PickupBerry() // berry should follow the mouse
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane = 3f;
        newPosition = Camera.main.ScreenToWorldPoint(mousePos);
        Berry.transform.localPosition = Vector3.Lerp(Berry.transform.localPosition,newPosition,80f * Time.deltaTime);
    }

    private void Update()
    {
        if(holding)
        PickupBerry();

        if(thrown)
        return;

        if(Input.GetMouseButtonDown(0))
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
            } else if (Input.GetMouseButtonUp(0))
            {
                endTime = Time.time;
                endPos = Input.mousePosition; 
                swipeDistance = (endPos-startPos).magnitude;
                swipeTime = endTime - startTime;
                if(swipeTime<0.5f && swipeDistance > 30f)
                {
                    //thrown ball
                    //CalSpeed();
                    //CalAngle();
                    rb.AddForce(new Vector3((angle.x * BerrySpeed), (angle.y*BerrySpeed),(angle.z*BerrySpeed)));
                    rb.useGravity = true;
                }
            }
    }

  

}
