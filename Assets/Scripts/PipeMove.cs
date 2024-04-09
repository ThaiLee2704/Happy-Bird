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
        if (Logic.Instance.IsLive)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else 
        {
            speed = 0;
        }

        if (gameObject.transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }
}
