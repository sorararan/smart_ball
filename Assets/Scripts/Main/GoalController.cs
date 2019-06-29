using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {
    private AudioSource audio_source;
    private bool is_sounded;

    [SerializeField]
    private float speed = 3.0f;
    private static int count;

    void Start() {
        audio_source = gameObject.GetComponent<AudioSource>();
        is_sounded = false;
        count = 0;
    }

    void Update() {
        // 移動
        this.transform.position -= transform.right * speed * Time.deltaTime;

        // まだ音がなってないかつフレームと一致でピッ
        if(this.transform.position.x <= -3.9 && !is_sounded){
            audio_source.Play();
            is_sounded = true;
        }

        // 遠くに行ったら消える
        if(this.transform.position.x <= -10f){
            Destroy(this.gameObject);
            if(GoalGenerator.get_is_finished() == true){
                count++;
                if(count == 10){
                    SceneController.go_next_scene_from("Main");
                }
            }
        }
    }
}
