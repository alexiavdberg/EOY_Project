using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
    public void PlayLevelOne()
    {
        SceneManager.LoadSceneAsync("Level1");
    }
    public void PlayLevelTwo()
    {
        SceneManager.LoadSceneAsync("Level2");
    }
    public void PlayLevelThree()
    {
        SceneManager.LoadSceneAsync("Level3");
    }
    public void EndGame()
    {
        SceneManager.LoadSceneAsync("EndGame");
    }
}
