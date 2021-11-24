using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds: MonoBehaviour
{
    private float leftLimit = 0;
    private float rightLimit = 80;
    private float upLimit = -20;
    private float downLimit = -100;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit){
            Destroy(gameObject);
        }
        else if (transform.position.x > rightLimit){
            Destroy(gameObject);
        }
        else if (transform.position.z > upLimit) {
            Destroy(gameObject);
        }
        else if (transform.position.z < downLimit) {
            Destroy(gameObject);
        }
    }
}
