using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviours
{
    // Start is called before the first frame update
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        body.velocity = new Vector2d(-2,body.velocity.y);
    }
}
