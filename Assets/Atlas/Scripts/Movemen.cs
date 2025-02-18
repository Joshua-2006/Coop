using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemen : MonoBehaviour
{
    public float horizontal;
    public float speed;
    public void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(transform.right * horizontal * speed * Time.deltaTime);
    }
}
