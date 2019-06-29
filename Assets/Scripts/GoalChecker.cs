using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour {
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Ball") {
            Debug.Log("あたり");
		}
    }
}
