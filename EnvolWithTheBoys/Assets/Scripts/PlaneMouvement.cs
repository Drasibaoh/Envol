using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMouvement : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;

    private bool status = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //transform.Rotate(Vector3.forward * -20);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            status = true;
            //RotateUp();
        }
       

        /*void RotateUp()
        {
            transform.Rotate(Vector3.forward * +20);
        }
        void RotateDown()
        {
            transform.Rotate(Vector3.forward * -20);
        }*/
    }
}
