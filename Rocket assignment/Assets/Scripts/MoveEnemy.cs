using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Vector2 vector;
    public int speed = 5;
    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        vector = new Vector2(0, 0);
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*speed * Time.deltaTime);
        //transform.position.y += speed;
        if (transform.position.y >= 13)
        {
            speed *= -1;
        }
        if (transform.position.y <= 2)
        {
            speed *= -1;
        }
    }

    //private void FixedUpdate()
    //{
    //    rb.AddRelativeForce(0, vector.y, 0);   
    //}
}
