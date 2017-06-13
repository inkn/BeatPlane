using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject bulletPrefab;
    public float rate=0.5f;
	void Start () {
        
    }
	
	
	void Update () {
        if (Hero._instance.isDeath) {
            stopFire();
        }
    }
   public void fire()
    {
       
            InvokeRepeating("Createbullet", rate, rate);
       
    }
    public void stopFire() {
        
        CancelInvoke("Createbullet");
    }
   public void Createbullet() {
        GameObject.Instantiate(bulletPrefab, transform.position, Quaternion.identity);

    }
   
}
