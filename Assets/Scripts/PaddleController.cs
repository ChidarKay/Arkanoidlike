using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

    public float paddleSpeed;



    void FixedUpdate() {
        Controls();
    }





    void Controls() {
        if (Input.GetKey("left")) {
            transform.position += new Vector3(-1, 0, 0) * paddleSpeed;
        }
        if (Input.GetKey("right")) {
            transform.position += new Vector3(1, 0, 0) * paddleSpeed;
        }
    }
}
