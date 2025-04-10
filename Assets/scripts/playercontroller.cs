using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontal;
    private float speed = 25;
    private float xRange = 7;
    public GameObject food;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *Time.deltaTime* speed * horizontal);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food,transform.position,food.transform.rotation);
        }
    }
}
