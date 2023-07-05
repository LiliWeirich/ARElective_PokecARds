using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnLocation;

    public void OnButtonClick()
    {
        Instantiate(prefab, spawnLocation.position, spawnLocation.rotation);
    }

}
