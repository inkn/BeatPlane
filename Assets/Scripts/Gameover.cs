using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour {
    public Text highestScore;
    private Text endScore;
 
	void Start () {
        endScore = gameObject.GetComponent<Text>();
        highestScore.text = "" + PlayerPrefs.GetInt("highestScore");
    }
	
	
	void Update () {
        endScore.text = "" + GameManager._instance.score;
       
       
    }
    public void onClick()
    {
       
        Application.LoadLevel(0);
    }
}
