using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsY : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}