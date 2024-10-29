using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -22; 
    private float bottomLimit = -5; 
    private bool isCaught = false;

    public void MarkAsCaught()
    {
        isCaught = true;
    }

    void Update()
    {
        
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        
        else if (transform.position.y < bottomLimit && !isCaught)
        {
            Debug.Log("Game Over! A ball hit the ground.");
            Destroy(gameObject);
        }
    }
}
