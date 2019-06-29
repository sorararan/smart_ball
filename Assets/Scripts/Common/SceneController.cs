using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            go_next_scene_from(SceneManager.GetActiveScene().name);
		}
    }

    public static void go_next_scene_from(string now_scene_name){
        if (now_scene_name == "Title"){
            ScoreManager.init_score();
            SceneManager.LoadScene ("Scenes/Main");
            return;
        }

        if (now_scene_name == "Main"){
            SceneManager.LoadScene ("Scenes/Result");
            return;
        }

        if (now_scene_name == "Result"){
            SceneManager.LoadScene ("Scenes/Title");
            return;
        }

        return;
    }
}
