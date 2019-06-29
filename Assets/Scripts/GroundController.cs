using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Ball") {
            Debug.Log("はずれ");
		}
    }
}
