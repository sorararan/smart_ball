using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGenerator : MonoBehaviour {
    private GameObject goal_prefab;
    readonly private  Vector3 InitGoalPos = new Vector3(5f, 0.2f, 0f);
    private float time_out;
    private int generate_count;
    private float time_elapsed;
    private static bool is_finished;

    void Start() {
        goal_prefab = (GameObject)Resources.Load ("Prefabs/Goal");
        time_elapsed = 0f;
        generate_count = 0;
        time_out = 1.5f;
        is_finished = false;
    }

    void Update() {
        if(!is_finished){
            time_elapsed += Time.deltaTime;
            if(time_elapsed >= time_out) {
                generate_goal();
                generate_count++;
                if(generate_count >= 4){
                    time_out -= 0.5f;
                    if(time_out < 0f){
                        is_finished = true;
                    }
                    generate_count = 0;
                }
                time_elapsed = 0.0f;
            }
        }
    }

    private void generate_goal(){
        if(goal_prefab != null){
            GameObject ini_ball = (GameObject) GameObject.Instantiate(goal_prefab, InitGoalPos, Quaternion.identity);
		}
    }

    public static bool get_is_finished(){
        return is_finished;
    }
}
