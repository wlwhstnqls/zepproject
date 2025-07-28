using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI gameEndText;
    public int score;
    int bestScore = 0;
    public int BestScore { get => bestScore; }

    public const string BestScoreKey = "BestScore";
    // Start is called before the first frame update
    void Start()
    {
        if (restartText == null)

            Debug.LogError("restart text is null");
        if (scoreText == null)
            Debug.LogError("score text is null");

        restartText.gameObject.SetActive(false);

        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);

    }

    // Update is called once per frame
    public void setRestart()
    {
        restartText.gameObject.SetActive(true);

    }
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
        PlayerPrefs.SetInt(BestScoreKey, bestScore);
    }

  

}