using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        // Save the player's starting position
        startPosition = transform.position;
    }

    public void Respawn()
    {
        // Move the player back to the starting position
        transform.position = startPosition;

        // Optionally reset velocity if using Rigidbody2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
