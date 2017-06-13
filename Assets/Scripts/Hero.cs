using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
    public float frameCountPersecond = 15;
    public Sprite[] sprites;
    public Sprite[] deathSprites;
    public static Hero _instance;
    public AudioSource award0;
    public AudioSource award1;
    public AudioSource gameOver;
    public GameObject boom;
    


    public GameObject bullettop;
    public GameObject bulletleft;
    public GameObject bulletright;

 
    public float superGunTime = 12;
    private float resetGunTime;
    private float timer = 0;
    private float timer0 = 0;
    private SpriteRenderer sprite;
    private bool isMouseDown = false;
    private Vector3 lastPosition=Vector3.zero ;
    private int gunType ;
    public bool isDeath=false;
	void Start () {
        sprite = this.GetComponent<SpriteRenderer>();
        _instance = this;
     
       
           bullettop.GetComponent<Bullet>().fire();
     
        
        resetGunTime = superGunTime;
        superGunTime = 0;
        gunType = 1;
        
    }
	
	
	void Update () {
        //主角动画
        timer += Time.deltaTime;
       int frameIndex = (int)(timer * frameCountPersecond);
        int frame = frameIndex % 2;
        if (!isDeath) { sprite.sprite = sprites[frame]; }
        //主角移动控制

        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
            lastPosition = Vector3.zero;
        }
        if (isMouseDown&&!isDeath)
        {
            if (lastPosition != Vector3.zero)
            {
                Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastPosition;
                transform.position += offset;
                checkPosition();
            }
           

            lastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        //处理主角超级子弹
        superGunTime -= Time.deltaTime;
        if (superGunTime > 0)
        {
            if (gunType == 1&&!isDeath)
            {
                
                
                superGun();
            }

        }
        else
        {
            if (gunType == 2)
            {
                ordinaryGun();
            }
        }


        //处理主角死亡
        if (isDeath)
        {
            bullettop.GetComponent<Bullet>().stopFire();
            timer0 += Time.deltaTime;
            int deathIndex = (int)(timer0 * frameCountPersecond * 0.2f);
            if (deathIndex < deathSprites.Length)
            {
               
                sprite.sprite = deathSprites[deathIndex];
               
            }
            else
            {

                Invoke("load1", 0.5f);
            }

        }

     
	}
    private void load1()
    {
        Application.LoadLevel(1);
    }
    void toDie() {

        isDeath = true;
        gameOver.Play();



    }
    void ordinaryGun()
    {
        gunType = 1;
        
       
            bulletleft.GetComponent<Bullet>().stopFire();
            bulletright.GetComponent<Bullet>().stopFire();
       

    }
    void superGun() {
        gunType = 2;
      
        
            bulletleft.GetComponent<Bullet>().fire();
            bulletright.GetComponent<Bullet>().fire();
        
    }

    void checkPosition() {
        Vector3 pos = transform.position;
        float x = pos.x;
        float y = pos.y;
        if (x > 2.17f) x = 2.17f;
        if (x <-2.17f) x = -2.17f;
        if (y > 3.68f) y = 3.68f;
        if (y < -3.82f) y = -3.82f;
        transform.position = new Vector3(x, y, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Award")
        {
            superGunTime = resetGunTime;
            
            Destroy(collision.gameObject);
            award0.Play();
        }
        if (collision.tag == "Enemy")
        {
            toDie();
        }
        if (collision.tag == "Award1")
        {
            Destroy(collision.gameObject);
            award1.Play();
            boom.SetActive(true);
           
          
        }
    }
    
}
