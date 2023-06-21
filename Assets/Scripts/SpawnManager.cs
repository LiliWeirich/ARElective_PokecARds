using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnObject;

    // Start is called before the first frame update
    public void SpawnObject()
    {
        Instantiate(spawnObject, transform);
    }

    
}
