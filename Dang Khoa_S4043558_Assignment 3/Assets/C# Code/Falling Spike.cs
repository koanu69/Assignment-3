using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of the spike
        initialPosition = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Reset player and spike
            collision.GetComponent<PlayerRespawn>().Respawn();
            ResetSpike();
        }
    }

    void ResetSpike()
    {
        // Reset the spike to its initial position
        transform.position = initialPosition;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}
