using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator; // Optional: If you have an opening animation
    private bool isOpen = false;

    private void Start()
    {
        // Get Animator if you want to add animation
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isOpen)
        {
            PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();
            if (playerInventory != null && playerInventory.hasKey)
            {
                OpenDoor();
            }
            else
            {
                Debug.Log("You need a key to open this door.");
            }
        }
    }

    private void OpenDoor()
    {
        isOpen = true;
        Debug.Log("Door opened!");

        // Play an animation if you have one
        if (animator != null)
        {
            animator.SetTrigger("Open");
        }
        else
        {
            // Alternatively, disable the door or move it
            gameObject.SetActive(false); // Hides the door
        }
    }
}

