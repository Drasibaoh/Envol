using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float movementModif = 0.1f;

    private Vector3 positionMovement;
    public Rigidbody2D o_rigidBody;

    void FixedUpdate()
    {
        positionMovement.x -= movementModif;
        o_rigidBody.MovePosition(transform.position + positionMovement * Time.fixedDeltaTime * movementSpeed);
    }
}
