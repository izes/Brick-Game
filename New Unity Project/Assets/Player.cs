using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Velocity = 10.0f;
    public float HorizontalAxis;
    public Rigidbody2D rigidbody2D;

    void Start() 
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2(Velocity * HorizontalAxis, 0);
    }
}
