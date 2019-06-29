using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    private const float OutSideOfLeft = -9.5f;

    void Update() {
        if(this.transform.position.x <= OutSideOfLeft){
            Destroy(this.gameObject);
        }
    }
}
