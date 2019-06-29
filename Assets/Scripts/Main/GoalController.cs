using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {
    [SerializeField]
    private float speed = 3.0f;

    void Update() {
        this.transform.position -= transform.right * speed * Time.deltaTime;
        if(this.transform.position.x <= -10f){
            Destroy(this.gameObject);
        }
    }
}
