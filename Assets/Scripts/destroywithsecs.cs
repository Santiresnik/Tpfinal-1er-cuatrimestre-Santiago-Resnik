using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywithsecs : MonoBehaviour
{
    float offset;
    void Start()
    {
        offset = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time-offset > 3)
        {
            Destroy(gameObject);
        }
    }
}
