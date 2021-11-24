using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager4 : MonoBehaviour
{
    public GameObject[] virusPrefabs;

    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVirus", startDelay, spawnInterval);
    }

    void SpawnVirus ()
    {

        int virusAmount = Random.Range(0, virusPrefabs.Length);
        Vector3 spawnPos = new Vector3(35, 0 , -78);

        Instantiate(virusPrefabs[virusAmount], spawnPos, virusPrefabs[virusAmount].transform.rotation * Quaternion.Euler(0, 0, 0));
    }
}