using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] virusPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = -2;

    private float startDelay = 1.0f;
    private float spawnInterval = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVirus", startDelay, spawnInterval);
    }

    void SpawnVirus ()
    {

        int virusAmount = Random.Range(0, virusPrefabs.Length);
        Vector3 spawnPos = new Vector3(36, 0 , -57);

        Instantiate(virusPrefabs[virusAmount], spawnPos, virusPrefabs[virusAmount].transform.rotation * Quaternion.Euler(0, 180, 0));
    }
}
