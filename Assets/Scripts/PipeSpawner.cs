using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
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
            if (Logic.Instance.IsLive)
            {
                Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-1, 3), 0), transform.rotation);
                timer = 0f;
            }
        }
    }
}
