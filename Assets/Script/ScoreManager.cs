using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI BestScore;
    

    Gamemanager gamemanager;
    UIManager uIManager;
    public Gamemanager Instance { get { return gamemanager; } }
    public UIManager UIInstance { get { return uIManager; } }   


    void Start()
    {
        Debug.Log("ScoreManager Start called");
        int bestScore = PlayerPrefs.GetInt("BestScore");
        Debug.Log("Best Score: " + bestScore);
        BestScore.text = bestScore.ToString();


    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
