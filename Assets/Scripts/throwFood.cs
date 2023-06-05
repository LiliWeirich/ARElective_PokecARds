using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwFood : MonoBehaviour
{
    public float force = 500f;
    public GameObject projectilPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var projectile = Instantiate(projectilPrefab);
            projectile.transform.position = Camera.main.transform.position;

            var rigidbody = projectile.GetComponent<Rigidbody>();
            rigidbody.AddForce(Camera.main.transform.forward * force);
        }
    }
}
