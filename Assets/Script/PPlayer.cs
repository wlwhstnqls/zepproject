using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPlayer : MonoBehaviour
{
    public const float speed = 2.5f;

    public GameObject interactionPopup;

    public string miniGmaeSceneName = "FlappyBirdScene";

    Gamemanager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        if (interactionPopup != null)
            interactionPopup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");     
        float moveY = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 move = new Vector3(moveX, moveY, 0).normalized;
            transform.position += move * Time.deltaTime * 2.5f;
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            Vector3 move = new Vector3(moveX, moveY, 0).normalized;
            transform.position += move * Time.deltaTime * 2.5f;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 move = new Vector3(moveX, moveY, 0).normalized;
            transform.position += move * Time.deltaTime * 2.5f;
            

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 move = new Vector3(moveX, moveY, 0).normalized;
            transform.position += move * Time.deltaTime * 2.5f;

        }
      

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (CanEnterMiniGame())
            {
                EnterMiniGame();
            }

        }

    }
        
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactionPopup.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            interactionPopup.SetActive(true);
        }

    }

   
    private bool CanEnterMiniGame()
    {

        return true;
    }

    private void EnterMiniGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("FlappyBirdScene");
    }
}

