using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour{
	private GameObject ball_prefab;
	readonly private Vector3 InitBallPos = new Vector3(7f, -3.5f, 0f);
	readonly private Vector3 BallDirection  = new Vector3(0.0f, 20.0f, 0.0f);

	void Start() {
		ball_prefab = (GameObject)Resources.Load ("Prefabs/Ball");
	}

    void Update() {
		// 左クリックボール生成
		if(Input.GetMouseButtonDown(0)){
		    if(ball_prefab != null){
			    GameObject ini_ball = (GameObject) GameObject.Instantiate(ball_prefab, InitBallPos, Quaternion.identity);
				ini_ball.GetComponent<Rigidbody>().velocity = BallDirection;
			}
		}
	}
}
