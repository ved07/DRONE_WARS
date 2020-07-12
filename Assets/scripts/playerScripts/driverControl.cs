 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driverControl : MonoBehaviour
{
    public float speed=10;
    public float riseSpeed=10;
    Rigidbody main;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.left * speed *Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down * riseSpeed * Time.deltaTime);
        }




    }
}
