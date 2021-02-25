using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Transform Target;
    public float Speed;
    public Rigidbody2D rb;
    private Vector2 movement;
    public float boundary;

    void Update()
    {
        movement = new Vector2(transform.position.x, Target.position.y);
        transform.position = Vector2.MoveTowards(transform.position, movement, Speed * Time.deltaTime);
        if (rb.position.y < -boundary)
        {
            transform.position = new Vector2(rb.position.x, -boundary);
        }
        if (rb.position.y > boundary)
        {
            transform.position = new Vector2(rb.position.x, boundary);
        }
    }
}
