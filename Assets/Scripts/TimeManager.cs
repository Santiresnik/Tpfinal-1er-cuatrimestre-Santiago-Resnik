using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTimeFloored;
    public float reset;
    // Start is called before the first frame update
    void Start()
    {
        reset = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        txtTimeFloored.text = Mathf.FloorToInt(Time.time - reset).ToString();

    }
}
