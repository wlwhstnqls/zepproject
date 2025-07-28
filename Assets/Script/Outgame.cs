using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outgame : MonoBehaviour
{
    public int score;

    public void EndMiniGame()
    {
        PlayerPrefs.SetInt("LastMiniGameScore", score); 
        PlayerPrefs.Save();

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMap");
    }
}
