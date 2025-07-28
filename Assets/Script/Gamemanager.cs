using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager gamemanager;

    BgLooper bgLooper;


    public static  Gamemanager Instance { get { return gamemanager; } }


    UIManager uiManager;
    public int currentScore = 0;
    public int BestScore = 0;
    public bool isGameOver = false;
    private void Awake()
    {
       gamemanager = this;
       uiManager = FindObjectOfType<UIManager>();
        
    }

    public void Start()
    {
        uiManager.UpdateScore(0);
        

    }
    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over!");
        uiManager.setRestart();
       
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
       
        currentScore += score;
        Debug.Log("Score: " + currentScore);
        uiManager.UpdateScore(currentScore);
        PlayerPrefs.SetInt("BestScore", currentScore);
        PlayerPrefs.Save();
        if (isGameOver == true)
        {
            currentScore -= 1;
        }
    }

   

}
