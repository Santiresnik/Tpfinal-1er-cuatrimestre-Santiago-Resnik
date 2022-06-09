using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    bool alive;
    public int depth;

    void Death()
    {
        Destroy(rb);
        SceneManager.LoadScene("GameOver");
    }
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
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Green")
        {
            Debug.Log("Win");
            SceneManager.LoadScene("Win");
        }
    }
}
