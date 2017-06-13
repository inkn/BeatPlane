using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkill : MonoBehaviour {


    public GameObject enemy0;
    private float timer = 0;
	void Start () {
		
	}
	
	
	void Update () {
        timer += Time.deltaTime;
        if (timer > 1.5f)
        {
            skill();
            timer = 0;
        }
		
	}
    void skill()
    {
        Instantiate(enemy0, transform.position, Quaternion.identity);
    }
}
