using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    public GameObject[] virusPrefabs;

    private float startDelay = 2.5f;
    private float spawnInterval = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVirus", startDelay, spawnInterval);
    }

    void SpawnVirus ()
    {

        int virusAmount = Random.Range(0, virusPrefabs.Length);
        Vector3 spawnPos = new Vector3(13, 0 , -65);

        Instantiate(virusPrefabs[virusAmount], spawnPos, virusPrefabs[virusAmount].transform.rotation * Quaternion.Euler(0, 90, 0));
    }
}
