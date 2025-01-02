using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpikeTrigger : MonoBehaviour
{
    public Rigidbody2D spikeRigidbody;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Activate the spike's gravity to make it fall
            spikeRigidbody.gravityScale = 1;
        }
    }
}
