using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public BoxCollider2D collider;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        rigidbody2D.constraints = new RigidbodyConstraints2D();
        collider.isTrigger = true;
    }
}
