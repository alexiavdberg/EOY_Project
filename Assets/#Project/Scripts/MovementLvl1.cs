using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementLvl1 : MonoBehaviour
{
    [SerializeField] private float speed = 3;
    private Vector3 direction = new Vector3(1, 0, 0);
    [SerializeField] public bool isStarting;

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

        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadSceneAsync("CongratulationsLvl1");
        }

        if (other.gameObject.CompareTag("OutOfZone"))
        {
            SceneManager.LoadSceneAsync("OutOfZoneLvl1");
        }

        if (other.gameObject.CompareTag("ToAvoid"))
        {
            SceneManager.LoadSceneAsync("CrushedInEnemyLvl1");
        }
        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));
    }
}