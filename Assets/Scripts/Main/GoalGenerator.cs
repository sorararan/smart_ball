using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGenerator : MonoBehaviour {
    private GameObject goal_prefab;
    readonly private  Vector3 InitGoalPos = new Vector3(5f, 0.2f, 0f);
    private float time_out;
    private const int GoalNum = 5;
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
        // ゴールを全て出したら終了
        if(!is_finished){
            time_elapsed += Time.deltaTime;
            // 一定時間で一つゴールを出す
            if(time_elapsed >= time_out) {
                GameObject goal;
                if(goal_prefab != null){
                    goal = (GameObject) GameObject.Instantiate(goal_prefab, InitGoalPos, Quaternion.identity);
                    generate_count++;
                    // ゴールをGoalNumだけ出したらテンポ変更
                    if(generate_count >= GoalNum){
                        time_out -= 0.5f;
                        if(time_out < 0f){
                            is_finished = true;
                            goal.GetComponent<GoalController>().is_final_goal();
                        }
                        generate_count = 0;
                    }
                }
                time_elapsed = 0.0f;
            }

        }
    }

    public static bool get_is_finished(){
        return is_finished;
    }
}
