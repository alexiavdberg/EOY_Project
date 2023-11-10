using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    private Vector3 direction = new Vector3(1, 0, 0);
    [SerializeField] private bool isStarting;

    private void Start()
    {
        isStarting = false;
    }
    private void Update()
    {
        if (isStarting)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
    public void StartLevel()
    {
        Debug.Log("CLICK");
        isStarting = true;
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
        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

        if (other.gameObject.CompareTag("OutOfZone"))
        {
            Debug.Log("OUT OF ZONE");
            SceneManager.LoadSceneAsync("OutOfZoneLvl1");
        }
        // if (other.gameObject.CompareTag("ToAvoid"))
        // {
        //     Debug.Log("Foncé dans ennemi");
        //     SceneManager.LoadSceneAsync("CrushedInEnemy");
        // }
    }
}