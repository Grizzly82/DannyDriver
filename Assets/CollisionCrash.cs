using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCrash : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Oh no, that's going to leave a mark");
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("You crossed the pink bridge");
    }
}
