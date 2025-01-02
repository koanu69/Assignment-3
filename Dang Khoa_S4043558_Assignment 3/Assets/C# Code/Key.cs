using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Give the player the key
            PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();
            if (playerInventory != null)
            {
                playerInventory.hasKey = true;
                Debug.Log("Key collected!");

                // Destroy the key
                Destroy(gameObject);
            }
        }
    }
}
