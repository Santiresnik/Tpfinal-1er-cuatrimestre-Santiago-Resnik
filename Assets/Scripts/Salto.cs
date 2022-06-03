using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float jumpForce;
    public int maxJumps;
    int hasJumps;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        hasJumps = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && hasJumps>0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJumps--;
        }
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJumps = maxJumps;
        }
    }
}
