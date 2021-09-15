using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Deactivate : MonoBehaviour
{

    public Shield_Pickup shieldActive;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            shieldActive.hasShield = false;
        }
    }
}
