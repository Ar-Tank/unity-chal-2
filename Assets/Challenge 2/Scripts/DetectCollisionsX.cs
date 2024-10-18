using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Only destroy the ball when it collides with the dog
        if (other.CompareTag("Dog"))  // checks if the collided object is tagged as "Dog"
        {
            Destroy(gameObject);
        }
    }
}
