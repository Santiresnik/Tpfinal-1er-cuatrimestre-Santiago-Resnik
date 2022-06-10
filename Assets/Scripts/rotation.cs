using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-rotationSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotationSpeed, 0, 0);
        }

    }
}
