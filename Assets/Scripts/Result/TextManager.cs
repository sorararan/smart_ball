using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
    [SerializeField]
    private Text text;

    void Start(){
        this.text.text = "score: " + ScoreManager.get_score().ToString();
    }
}
