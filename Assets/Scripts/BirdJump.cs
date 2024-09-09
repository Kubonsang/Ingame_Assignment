using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    public Rigidbody2D _rigidbody2D { get; private set; }
    public float _jumpC = 3f;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("GameOverScene");    
    }

    void jump()
    {
        _rigidbody2D.velocity = Vector2.up * _jumpC;
    }
}
