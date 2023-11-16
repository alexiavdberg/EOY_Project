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
        // SceneManager.LoadSceneAsync("MainMenu");
        LoadNextLevel("MainMenu");
    }
    public void PlayLevelOne()
    {
        // SceneManager.LoadSceneAsync("Level1");
        LoadNextLevel("Level1");
    }
    public void PlayLevelTwo()
    {
        // SceneManager.LoadSceneAsync("Level2");
        LoadNextLevel("Level2");
    }
    public void PlayLevelThree()
    {
        // SceneManager.LoadSceneAsync("Level3");
        LoadNextLevel("Level3");
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // LoadNextLevel(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndGame()
    {
        // SceneManager.LoadSceneAsync("EndGame");
        LoadNextLevel("EndGame");
    }
    public void CrushedInEnemyLvl1()
    {
        // SceneManager.LoadSceneAsync("CrushedInEnemyLvl1");
        LoadNextLevel("CrushedInEnemyLvl1");
    }
    public void CrushedInEnemyLvl2()
    {
        // SceneManager.LoadSceneAsync("CrushedInEnemyLvl2");
        LoadNextLevel("CrushedInEnemyLvl2");
    }
    public void CrushedInEnemyLvl3()
    {
        // SceneManager.LoadSceneAsync("CrushedInEnemyLvl3");
        LoadNextLevel("CrushedInEnemyLvl3");
    }
    public void OutOfZoneLvl1()
    {
        // SceneManager.LoadSceneAsync("OutOfZoneLvl1");
        LoadNextLevel("OutOfZoneLvl1");
    }
    public void OutOfZoneLvl2()
    {
        // SceneManager.LoadSceneAsync("OutOfZoneLvl2");
        LoadNextLevel("OutOfZoneLvl2");
    }
    public void OutOfZoneLvl3()
    {
        // SceneManager.LoadSceneAsync("OutOfZoneLvl3");
        LoadNextLevel("OutOfZoneLvl3");
    }
    public void ChooseLevel()
    {
        LoadNextLevel("ChooseLevel");
        // SceneManager.LoadSceneAsync("ChooseLevel");
    }
}