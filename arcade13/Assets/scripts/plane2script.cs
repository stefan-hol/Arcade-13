using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane2script: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int speed = 8;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -speed) * Time.deltaTime;
        }
    }
}
