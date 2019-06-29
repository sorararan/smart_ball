using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGenerator : MonoBehaviour {
    private GameObject goal_prefab;
    readonly private  Vector3 InitGoalPos = new Vector3(5f, 0.2f, 0f);
    private const float TimeOut = 3f;
    private float time_elapsed = 0f;

    void Start() {
        goal_prefab = (GameObject)Resources.Load ("Prefabs/Goal");
    }

    void Update() {
        time_elapsed += Time.deltaTime;
        if(time_elapsed >= TimeOut) {
            generate_goal();
            time_elapsed = 0.0f;
        }
    }

    private void generate_goal(){
        if(goal_prefab != null){
            GameObject ini_ball = (GameObject) GameObject.Instantiate(goal_prefab, InitGoalPos, Quaternion.identity);
		}
    }
}
