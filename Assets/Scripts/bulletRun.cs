using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletRun : MonoBehaviour {

    public float speed = 5;
    private Transform tran;
	void Start () {
        tran = gameObject.GetComponent<Transform>();
	}
	
	
	void Update () {
       transform.Translate( Vector3.up*speed*Time.deltaTime);
        if (tran.position.y >= 4.1f) {
            Destroy(gameObject);
        
       };
	}
   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {if (!collision.GetComponent<Enemy>().isDeath)
            {
                collision.gameObject.SendMessage("beHit");
                Destroy(this.gameObject);
            }
        }
    }
}
