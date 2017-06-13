using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {

    public GameObject[] enemy;
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
    public void onClick()
    {
        if (!Hero._instance.isDeath)
        {
            enemy = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].GetComponent<Enemy>().toDie();
            }

           this.gameObject.SetActive(false);
        }
       
    }
}
