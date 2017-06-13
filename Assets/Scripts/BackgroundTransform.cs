using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTransform : MonoBehaviour {

    private float speed = 2;
	void Update () {
        this.transform.Translate(Vector3.down*speed*Time.deltaTime);
        Vector3 position = this.transform.position;
        if (position.y < -12.78f) {
           this.transform.position = new Vector3(position.x, position.y + 12.78f* 2, position.z);
        };
	}
}
