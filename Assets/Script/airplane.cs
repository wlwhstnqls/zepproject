using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D _rigidbody;

    public float FlapForce = 6f;
    public float FowardSpeed = 3f;
    public bool IsDead = false;
    float deathCooldown = 0f;

    bool isFlap = false;

    public bool GodMode = false;


    Gamemanager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = Gamemanager.Instance;

        animator = GetComponentInChildren<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();

        if (animator == null)
        {
            Debug.LogError("Not Founded Animator");
        }

        if (_rigidbody == null)
        {
            Debug.LogError("Not Founded Rigidbody");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (IsDead)
        {
            if (deathCooldown <= 0)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
                }

            }
            else
            {
                deathCooldown -= Time.deltaTime;
            }
        }
        else
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
            {
                isFlap = true;

            }



        }
    }


    private void FixedUpdate()
    {
        if (IsDead) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = FowardSpeed;

        if (isFlap)
        {
            velocity.y = FlapForce;
            isFlap = false;
        }


        _rigidbody.velocity = velocity;

        float angle = Mathf.Clamp((_rigidbody.velocity.y * 10f), -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GodMode) return;

        if (IsDead) return;

        IsDead = true;
        deathCooldown = 1f;

        animator.SetInteger("IsDie", 1);
        gamemanager.GameOver();
    }
}
