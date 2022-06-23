using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    AudioSource source;
    public float jumpForce;
    public int maxJumps;
    public GameObject pelota;
    int hasBalls;
    int hasJumps;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        hasJumps = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasJumps > 0)
        {
            for (hasBalls = 0; hasBalls <= 3; hasBalls++)
            {
                Instantiate(pelota, new Vector3(transform.position.x + 20, transform.position.y + 8, transform.position.z), Quaternion.identity);
            }
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
