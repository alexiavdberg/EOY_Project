using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.5f;

    public void LoadNextLevel(string scene)
    {
        StartCoroutine(LoadLevel(scene));
    }

    IEnumerator LoadLevel(string scene)
    {
        transition.SetTrigger("StartAnimation");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(scene);
    }


    public void MainMenu()
    {
        LoadNextLevel("MainMenu");
    }
    public void PlayLevelOne()
    {
        LoadNextLevel("Level1");
    }
    public void PlayLevelTwo()
    {
        LoadNextLevel("Level2");
    }
    public void PlayLevelThree()
    {
        LoadNextLevel("Level3");
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndGame()
    {
        LoadNextLevel("EndGame");
    }
    public void CrushedInEnemyLvl1()
    {
        LoadNextLevel("CrushedInEnemyLvl1");
    }
    public void CrushedInEnemyLvl2()
    {
        LoadNextLevel("CrushedInEnemyLvl2");
    }
    public void CrushedInEnemyLvl3()
    {
        LoadNextLevel("CrushedInEnemyLvl3");
    }
    public void OutOfZoneLvl1()
    {
        LoadNextLevel("OutOfZoneLvl1");
    }
    public void OutOfZoneLvl2()
    {
        LoadNextLevel("OutOfZoneLvl2");
    }
    public void OutOfZoneLvl3()
    {
        LoadNextLevel("OutOfZoneLvl3");
    }
    public void ChooseLevel()
    {
        LoadNextLevel("ChooseLevel");
    }
}