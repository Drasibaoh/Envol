using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDestroyer : MonoBehaviour
{
    public GameObject Shield;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            Shield.GetComponentInParent<Shield_Pickup>().hasShield = false;
        }
    }

}
