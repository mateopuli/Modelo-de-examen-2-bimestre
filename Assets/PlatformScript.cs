using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float xSpeed;
    public float xRightLimit;
    public float xLeftLimit;
    public bool toRight;
    
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
        }
        else if (transform.position.x <= xLeftLimit)
        {
            toRight = true;
        }
    }
}
