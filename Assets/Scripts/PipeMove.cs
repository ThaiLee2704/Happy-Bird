using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Logic.IsLive)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            speed = 0;
        }
    }
}
