using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    private static int score_point = 0;

    public static int get_score(){
        return score_point;
    }

    public static void up_score(){
        score_point++;
    }

    public static void init_score(){
        score_point = 0;
    }
}
