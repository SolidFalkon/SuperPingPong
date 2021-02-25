using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPVP : MonoBehaviour
{
    public Rigidbody2D rb;
    public float boundary;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.UpArrow)))
        {
            rb.velocity = new Vector2(0f, 5f);
        }
        else if ((Input.GetKey(KeyCode.DownArrow)))
        {
            rb.velocity = new Vector2(0f, -5f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }

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
