using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player collided with the spike
        if (collision.CompareTag("Player"))
        {
            // Call the Respawn method on the player
            PlayerRespawn player = collision.GetComponent<PlayerRespawn>();
            if (player != null)
            {
                player.Respawn();
            }
        }
    }
}