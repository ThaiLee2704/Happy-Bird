using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pepi;
    [SerializeField] float timer = 0f;
    [SerializeField] float timeValue = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        if (timer < timeValue)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(pepi, new Vector3(transform.position.x, Random.Range(-1, 3), 0), transform.rotation);
            timer = 0f;
        }
    }
}
