using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entergame : MonoBehaviour
{
    public GameObject popupUI;
    public string miniGameSceneName = "FlappyBirdScene";
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.CompareTag("Player"))
      {
         popupUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            popupUI.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (CanEnterMiniGame()) 
            {
                EnterMiniGame();
            }
        }
    }

    private bool CanEnterMiniGame()
    {
      return true;
    }

    private void EnterMiniGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGameSceneName);
    }
}
