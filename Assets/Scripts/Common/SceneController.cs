using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (SceneManager.GetActiveScene().name == "Title"){
                SceneManager.LoadScene ("Scenes/Main");
            }
		}

        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (SceneManager.GetActiveScene().name == "Main"){
                SceneManager.LoadScene ("Scenes/Title");
            }
        }
    }
}
