using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementLvl3 : MonoBehaviour
{
    private float speed;
    private Vector3 direction;
    [SerializeField] private bool isStarting;
    private Animator playerAnimator;
    private float cherries;

    private void Start()
    {
        isStarting = false;
        speed = 3f;
        direction = new Vector3(1, 0, 0);
        playerAnimator = gameObject.GetComponent<Animator>();
        cherries = 12f;
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
        playerAnimator.SetTrigger("goRight");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Up"))
        {
            direction = new Vector3(0, 1, 0);
            playerAnimator.SetTrigger("goUp");
        }
        if (other.gameObject.CompareTag("Left"))
        {
            direction = new Vector3(-1, 0, 0);
            playerAnimator.SetTrigger("goLeft");
        }
        if (other.gameObject.CompareTag("Right"))
        {
            direction = new Vector3(1, 0, 0);
            playerAnimator.SetTrigger("goRight");
        }
        if (other.gameObject.CompareTag("Down"))
        {
            direction = new Vector3(0, -1, 0);
            playerAnimator.SetTrigger("goDown");
        }
        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

        if (other.gameObject.CompareTag("ToCatch"))
        {
            cherries--;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Finish") && cherries == 0)
        {
            SceneManager.LoadSceneAsync("CongratulationsLvl3");
        }
        if (other.gameObject.CompareTag("Finish") && cherries > 0)
        {
            SceneManager.LoadSceneAsync("TryAgainLvl3");
        }

        if (other.gameObject.CompareTag("OutOfZone"))
        {
            SceneManager.LoadSceneAsync("OutOfZoneLvl3");
        }

        if (other.gameObject.CompareTag("ToAvoid"))
        {
            SceneManager.LoadSceneAsync("CrushedInEnemyLvl3");
        }
        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));
    }
}