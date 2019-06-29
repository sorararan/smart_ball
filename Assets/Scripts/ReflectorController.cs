﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectorController : MonoBehaviour {
    // right_upは0、left_upは1
    [SerializeField]
    private int wall_id = 0;
    readonly private Vector3[] ReflectDirections = {
        new Vector3(-40f, 0f, 0f), 
        new Vector3(0f, -20f, 0f)
    };
	  private Vector3 reflect_direction;

	  void Start() {
		    reflect_direction = ReflectDirections[wall_id];
	  }

    void OnCollisionEnter(Collision collision) {
		    if(collision.gameObject.tag == "Ball") {
			      collision.gameObject.GetComponent<Rigidbody>().velocity = reflect_direction;
		    }
	  }
}