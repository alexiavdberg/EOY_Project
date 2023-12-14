using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementLvl1 : MonoBehaviour
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
        playerAnimator = gameObject.GetComponent<Animator>();
        cherries = 6f;
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
        direction = new Vector3(1, 0, 0);
        playerAnimator.SetTrigger("goRight");
        SoundManager.Instance.PlayEffect("button");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Up") && isStarting)
        {
            direction = new Vector3(0, 1, 0);
            playerAnimator.SetTrigger("goUp");
            SoundManager.Instance.PlayEffect("changeDirection");    
        }
        if (other.gameObject.CompareTag("Left") && isStarting)
        {
            direction = new Vector3(-1, 0, 0);
            playerAnimator.SetTrigger("goLeft");
            SoundManager.Instance.PlayEffect("changeDirection");
        }
        if (other.gameObject.CompareTag("Right") && isStarting)
        {
            direction = new Vector3(1, 0, 0);
            playerAnimator.SetTrigger("goRight");
            SoundManager.Instance.PlayEffect("changeDirection");
        }
        if (other.gameObject.CompareTag("Down") && isStarting)
        {
            direction = new Vector3(0, -1, 0);
            playerAnimator.SetTrigger("goDown");
            SoundManager.Instance.PlayEffect("changeDirection");
        }
        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));

        if (other.gameObject.CompareTag("ToCatch"))
        {
            cherries--;
            Destroy(other.gameObject);
            SoundManager.Instance.PlayEffect("grabCherry");
        }

        if (other.gameObject.CompareTag("Finish") && cherries == 0)
        {
            isStarting = false;
            SceneManager.LoadSceneAsync("CongratulationsLvl1");
            SoundManager.Instance.PlayEffect("win");
        }
        if (other.gameObject.CompareTag("Finish") && cherries > 0)
        {
            isStarting = false;
            SceneManager.LoadSceneAsync("TryAgainLvl1");
            SoundManager.Instance.PlayEffect("lose");
        }

        if (other.gameObject.CompareTag("OutOfZone"))
        {
            SceneManager.LoadSceneAsync("OutOfZoneLvl1");
            SoundManager.Instance.PlayEffect("outOfZone");
        }

        if (other.gameObject.CompareTag("ToAvoid"))
        {
            SceneManager.LoadSceneAsync("CrushedInEnemyLvl1");
            SoundManager.Instance.PlayEffect("touchEagle");
        }
    }
}