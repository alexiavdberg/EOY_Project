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
        SoundManager.Instance.PlayMusic("MenuTheme");
        LoadNextLevel("MainMenu");
        SoundManager.Instance.PlayEffect("button");
    }
    public void PlayLevelOne()
    {
        LoadNextLevel("Level1");
        SoundManager.Instance.PlayEffect("button");
        SoundManager.Instance.PlayMusic("Theme");
    }
    public void PlayLevelTwo()
    {
        LoadNextLevel("Level2");
        SoundManager.Instance.PlayEffect("button");
    }
    public void PlayLevelThree()
    {
        LoadNextLevel("Level3");
        SoundManager.Instance.PlayEffect("button");
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SoundManager.Instance.PlayEffect("button");
    }
    public void EndGame()
    {
        LoadNextLevel("EndGame");
        SoundManager.Instance.PlayEffect("button");
    }
    public void CrushedInEnemyLvl1()
    {
        LoadNextLevel("CrushedInEnemyLvl1");
        SoundManager.Instance.PlayEffect("button");
    }
    public void CrushedInEnemyLvl2()
    {
        LoadNextLevel("CrushedInEnemyLvl2");
        SoundManager.Instance.PlayEffect("button");
    }
    public void CrushedInEnemyLvl3()
    {
        LoadNextLevel("CrushedInEnemyLvl3");
        SoundManager.Instance.PlayEffect("button");
    }
    public void OutOfZoneLvl1()
    {
        LoadNextLevel("OutOfZoneLvl1");
        SoundManager.Instance.PlayEffect("button");
    }
    public void OutOfZoneLvl2()
    {
        LoadNextLevel("OutOfZoneLvl2");
        SoundManager.Instance.PlayEffect("button");
    }
    public void OutOfZoneLvl3()
    {
        LoadNextLevel("OutOfZoneLvl3");
        SoundManager.Instance.PlayEffect("button");
    }
    public void ChooseLevel()
    {
        LoadNextLevel("ChooseLevel");
        SoundManager.Instance.PlayEffect("button");
        SoundManager.Instance.PlayMusic("Theme");
    }
    public void QuitGame()
    {
        Application.Quit();
        SoundManager.Instance.PlayEffect("button");
    }
}