using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public SpawnManagerX spawnManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            
            other.GetComponent<DestroyOutOfBoundsX>().MarkAsCaught();

            Destroy(other.gameObject); 
            spawnManager.SpawnRandomBall(); 
        }
    }
}
