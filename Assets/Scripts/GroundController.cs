using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {
    private AudioSource audio_source;

    void Start () {
        audio_source = gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Ball") {
            audio_source.Play ();
		}
    }
}
