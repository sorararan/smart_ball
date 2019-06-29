using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
    private Text score_text;

    void Start(){
        score_text = this.GetComponent<Text>();
        this.score_text.text = "score: " + ScoreManager.get_score().ToString();
    }
}
