using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    AudioSource source;
    public float jumpForce;
    public int maxJumps;
    public GameObject pelota;
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
        if (Input.GetKeyDown(KeyCode.Space) && hasJumps>0)
        {
            Instantiate(pelota, new Vector3(transform.position.x, transform.position.y+2, transform.position.z), Quaternion.identity);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJumps--;
            source.Play();

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
