using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 playerPosition;

    private void Start()
    {
        playerPosition = transform.position;
    }
    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Up")
        {
            playerPosition.y -= 1;
        }
        if (collision.gameObject.tag == "Left")
        {
            playerPosition.y -= 1;
        }
        if (collision.gameObject.tag == "Down")
        {
            playerPosition.y += 1;
        }
        if (collision.gameObject.tag == "Right")
        {
            playerPosition.x += 1;
        }
        transform.position = playerPosition;
    }
}
