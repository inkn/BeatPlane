using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager _instance;
    public int score = 0;
   
    private Text scoreUI;
	void Awake () {
        _instance = this;
        scoreUI = GameObject.FindGameObjectWithTag("ScoreUI").GetComponent<Text>();
        

	}
	
	// Update is called once per frame
	void Update () {
     
        scoreUI.text = "Score: " + score;
        if(score> PlayerPrefs.GetInt("highestScore")) {
            PlayerPrefs.SetInt("highestScore", score);
        }
        

    }
}
