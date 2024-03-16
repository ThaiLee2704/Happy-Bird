using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Logic : MonoBehaviour
{
    [SerializeField] GameObject bird;
    [SerializeField] static bool isLive = true;
    public static bool IsLive => isLive;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Pipe"))
        {
            Destroy(bird);
            isLive = false;
        }
    }
}
