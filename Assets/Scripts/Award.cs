﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Award : MonoBehaviour {

    public float speed = 3;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
	}
}
