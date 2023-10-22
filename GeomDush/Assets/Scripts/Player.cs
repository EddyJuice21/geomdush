using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rb;
    bool isGrounded;


    void Start()
    {
        isGrounded = true;

    }

    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                Jump(jumpForce);            
            }
        }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isGrounded = true;
        if (other.gameObject.CompareTag("Hole"))
            SceneManager.LoadScene("GameScene");

    }

    void Jump(float jumpForce)
    {
        rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
                isGrounded = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hole"))
        {
            ScoreManager.Instance.AddScore(1);
        }
        
        if (other.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("SecondScene");
        }

        if (other.gameObject.CompareTag("Portall"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
