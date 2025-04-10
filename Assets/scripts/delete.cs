using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    private float minimalBound = -3.5f;
    private float maxBound = 18.8f;
    void Update()
    {
        if (transform.position.z < minimalBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > maxBound)
        {
            Destroy(gameObject);
            Debug.Log("game over");
            Debug.Log("you faild to feed skz");
        }
    }
}
