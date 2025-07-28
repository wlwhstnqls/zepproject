using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    static Gamemanager gamemanager;

   

    public static Gamemanager Instance { get { return gamemanager; } }


    UIManager uiManager;
    public int currentScore = 0;
    
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
    }

   

}
