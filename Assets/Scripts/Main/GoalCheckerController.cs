using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheckerController : MonoBehaviour {
    private AudioSource audio_source;

    void Start () {
        audio_source = gameObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.tag == "Ball") {
            ScoreManager.up_score();
            audio_source.Play();
		}
    }
}
