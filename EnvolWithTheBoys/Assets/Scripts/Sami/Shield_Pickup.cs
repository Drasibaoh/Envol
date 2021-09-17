using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Pickup : MonoBehaviour
{

    public bool hasShield = false;
    public GameObject shield;

    void Update()
    {
        if(hasShield == true)
        {
            shield.SetActive(true);
        }

        else
        {
            shield.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Shield") && hasShield == false)
        {
            hasShield = true;
            Destroy(collision.gameObject);
        }
    }

}
