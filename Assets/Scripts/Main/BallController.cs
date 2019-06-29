using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    void Update() {
        if(this.transform.position.x <= -9.5f){
            Destroy(this.gameObject);
        }
    }
}
