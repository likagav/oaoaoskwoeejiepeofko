using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delete : MonoBehaviour
{
    private float minimalBound = -3.5f;
    private float maxBound = 18.8f;
    private int attempt = 5;
    public Image[] hearts;
    void Update()
    {
        if (transform.position.z < minimalBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > maxBound)
        {
            Destroy(gameObject);
            if (attempt > 0)
            {
                attempt--;
                Debug.Log(attempt);
            }
            else
            {
                Debug.Log("game over");
                Debug.Log("you faild to feed skz");
            }
        }
    }
}
