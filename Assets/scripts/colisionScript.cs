using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }

}
