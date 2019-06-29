using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {
    private const float OutSideOfLeft = -9.5f;
    private const float FrameLeft = -3.9f;
    private AudioSource audio_source;
    private bool is_sounded;

    [SerializeField]
    private float speed = 3.0f;
    private bool is_last = false;

    void Start() {
        audio_source = gameObject.GetComponent<AudioSource>();
        is_sounded = false;
    }

    void Update() {
        // 移動
        this.transform.position -= transform.right * speed * Time.deltaTime;

        // まだ音がなってないかつフレームと一致でピッ
        if(this.transform.position.x <= FrameLeft && !is_sounded){
            audio_source.Play();
            is_sounded = true;
        }

        // 遠くに行ったら消える
        if(this.transform.position.x <= OutSideOfLeft){
            Destroy(this.gameObject);
            if(this.is_last){
                SceneSwitcher.go_next_scene_from("Main");
            }
        }
    }

    public void is_final_goal(){
        this.is_last = true;
    }
}
