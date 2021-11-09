using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public Rigidbody rb;
    public Vector2 vector;
    public int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vector = new Vector2(0, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        vector.x = 0;
        vector.y = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vector.x = 5;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vector.x = -5;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            vector.y = 14;
        }
    }
    void FixedUpdate()
    {
        rb.AddRelativeForce(0, vector.y, 0);
        rb.AddRelativeTorque(0, 0, vector.x, 0);
    }
}
