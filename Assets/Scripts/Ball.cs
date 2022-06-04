using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    bool alive;
    public int depth;

    // Start is called before the first frame update
    void Start()
    {

        alive = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            if (rb.position.y < -depth)
            {
                alive = false;
                Death();
                gameObject.SetActive(false);
            }
        }
    }
    void Death()
    {
     Destroy(rb);
    }
}
