using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public float rateCren0 = 1.8f;
    public float rateCren1 = 3.2f;
    public float rateCren2 = 20.0f;
    public float rateCraw0 = 45.0f;
    public float rateCraw1 = 50.0f;
    public GameObject ene0;
    public GameObject ene1;
    public GameObject ene2;
    public GameObject award0;
    public GameObject award1;
    public AudioSource audio0;



	
	void Start () {
        InvokeRepeating("cren0", rateCren0, rateCren0);
        InvokeRepeating("cren1", rateCren1, rateCren1);
        InvokeRepeating("cren2", 30.0f, rateCren2);
        InvokeRepeating("craw0", 5.0f, rateCraw0*2);
        InvokeRepeating("craw1", 2.0f, rateCraw1*2);
    }
	
	
	void Update () {
		
	}

    void cren0() {
        float x = Random.Range(-2.27f, 2.27f);
        Instantiate(ene0, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
    void cren1()
    {
        float x = Random.Range(-2.04f, 2.04f);
        Instantiate(ene1, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
    void cren2()
    {
        float x = Random.Range(-1.59f, 1.59f);
        Instantiate(ene2, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
    void craw0()
    {
        audio0.Play();
        float x = Random.Range(-2.22f, 2.22f);
        Instantiate(award0, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
    void craw1()
    {
        audio0.Play();
        float x = Random.Range(-2.22f, 2.22f);
        Instantiate(award1, new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }
}
