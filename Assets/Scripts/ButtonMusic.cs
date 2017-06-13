using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMusic : MonoBehaviour {

    public AudioSource button;
	void Start () {
		
	}
	
	
	void Update () {
		
	}
    public void onClick()
    {
        button.Play();
    }
}
