using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    public int score = 100;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput,vInput,0);
    }

    public void Up()
    {
        transform.Translate(0,speed,0);
    }
    public void Down()
    {
        transform.Translate(0,-speed,0);
    }
}
