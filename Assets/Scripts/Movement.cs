using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float strenght = 5f;
    public Logic logic;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                rb.velocity = Vector2.up * strenght;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D orther)
    {
        logic.gameOver();
    }
    
}
