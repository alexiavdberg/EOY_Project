using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 2;
    private Vector3 direction = new Vector3(1, 0, 0);

    private void Start()
    {
        
    }
    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Up"))
        {
            direction = new Vector3(0, 1, 0);
        }
        if (other.gameObject.CompareTag("Left"))
        {
            direction = new Vector3(-1, 0, 0);
        }
        if (other.gameObject.CompareTag("Right"))
        {
            direction = new Vector3(1, 0, 0);
        }
        if (other.gameObject.CompareTag("Down"))
        {
            direction = new Vector3(0, -1, 0);
        }
    }
}