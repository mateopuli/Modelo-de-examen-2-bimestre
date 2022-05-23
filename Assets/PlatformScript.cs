﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xRightLimit;
    public float xLeftLimit;
    public bool toRight;

    public GameObject prefab1;
    public GameObject prefab2;

    public GameObject BaseIzq;
    public GameObject BaseDer;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if(toRight == true)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xRightLimit)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = BaseDer.transform.position + new Vector3(0,1,0);
        }
        else if (transform.position.x <= xLeftLimit)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = BaseIzq.transform.position + new Vector3(0, 1, 0);
        }
    }
}
