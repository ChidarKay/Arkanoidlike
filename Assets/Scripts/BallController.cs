using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallController : MonoBehaviour {

    public float initialThrust;
    public float unacceptableAngle;
    float angleOfMovement;
    Rigidbody2D rb;
    Vector2 initialDir;
    Vector3 oldVelocity;




    void Start() {
        initialDir = Vector2.up;
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        rb.AddForce(initialDir * initialThrust);

    }

    void Update() {
       
    }

    void FixedUpdate() {
        print(rb.velocity);
        Debug.DrawLine(Vector2.right, rb.velocity);

        oldVelocity = rb.velocity;
    }





    void OnCollisionEnter2D(Collision2D coll) {
        angleOfMovement = Vector2.Angle(rb.velocity, Vector2.right);

        if (angleOfMovement < unacceptableAngle) {
            
        }
    }
}
