using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomMusic : MonoBehaviour {

    private AudioSource boom;
	void Start () {
        boom = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onBoom() {
        if (!Hero._instance.isDeath) {
            boom.Play();
            Invoke("endMusic", 1.5f);
        } 
    }
    void endMusic()
    {
        boom.Stop();
    }
}
