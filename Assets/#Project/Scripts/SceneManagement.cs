using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
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
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void EndGame()
    {
        SceneManager.LoadSceneAsync("EndGame");
    }
    public void CrushedInEnemyLvl1()
    {
        SceneManager.LoadSceneAsync("CrushedInEnemyLvl1");
    }
    public void CrushedInEnemyLvl2()
    {
        SceneManager.LoadSceneAsync("CrushedInEnemyLvl2");
    }
    public void CrushedInEnemyLvl3()
    {
        SceneManager.LoadSceneAsync("CrushedInEnemyLvl3");
    }
    public void OutOfZoneLvl1()
    {
        SceneManager.LoadSceneAsync("OutOfZoneLvl1");
    }
    public void OutOfZoneLvl2()
    {
        SceneManager.LoadSceneAsync("OutOfZoneLvl2");
    }
    public void OutOfZoneLvl3()
    {
        SceneManager.LoadSceneAsync("OutOfZoneLvl3");
    }
}
