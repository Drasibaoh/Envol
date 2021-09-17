using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Destroy : MonoBehaviour
{
    public GameObject obstacle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Shield_Power"))
        {   
            Destroy(obstacle);
        }
    }
}
