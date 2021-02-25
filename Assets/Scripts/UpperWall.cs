using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperWall : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * Speed) * 2f + 2.6f, transform.position.z);
    }
}
