using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWall : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.fixedTime * Speed) * 3.7f,transform.position.z);
    }
}
