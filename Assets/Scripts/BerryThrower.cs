using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryThrower : MonoBehaviour
{
    public float force = 500f;
    public GameObject projectilPrefab;
    private bool canThrow = true; // Flag variable to track if an object can be thrown

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canThrow)
        {
            canThrow = false; // Set the flag to false to prevent throwing another object

            var projectile = Instantiate(projectilPrefab);
            projectile.transform.position = Camera.main.transform.position;

            var rigidbody = projectile.GetComponent<Rigidbody>();
            rigidbody.AddForce(Camera.main.transform.forward * force);

            StartCoroutine(ResetThrowFlag());
        }
    }

    IEnumerator ResetThrowFlag()
    {
        yield return new WaitForSeconds(1f); // Adjust the delay if needed
        canThrow = true; // Reset the flag after a certain duration
    }
}
