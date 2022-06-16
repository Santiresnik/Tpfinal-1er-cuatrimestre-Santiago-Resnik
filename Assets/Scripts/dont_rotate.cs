using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont_rotate : MonoBehaviour
{
    public GameObject target;
    void FixedUpdate()
    {
        transform.position = new Vector3(target.transform.position.x-30, target.transform.position.y+20, target.transform.position.z-2);
        target.transform.Rotate(new Vector3(transform.position.x, -transform.position.y, 0)  * Time.deltaTime);
        target.transform.eulerAngles = new Vector3(target.transform.eulerAngles.x,
        target.transform.eulerAngles.y, 0);
    }
}

