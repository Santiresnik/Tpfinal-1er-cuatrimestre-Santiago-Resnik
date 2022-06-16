using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject plat;
    float direccion = 2f;


    void Update()
    {
        Debug.Log(plat.transform.position.z);
        plat.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + direccion * Time.deltaTime);
        if (plat.transform.position.z > 15)
        {
            direccion *= -1;
        }
        else if (plat.transform.position.z < -15)
        {
            direccion *= -1;
        }
    }
}
