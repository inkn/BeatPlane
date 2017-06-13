using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy: MonoBehaviour {
    public int Hp = 1;
    public float speed = 2;
    public int score = 100;
    public float endY = -3.8f;
    private Transform trans;
    public bool isDeath = false;
    private bool isHurt = false;
    public Sprite[] deathSprites;
    public AudioSource deathMusic;
    public int frame = 10;
    public float timer = 0;
    public float hurttimer = 0;


    private SpriteRenderer sprit;
    public Sprite[] hurtSprites;

    private BoxCollider2D box;
	void Start () {
        trans = gameObject.GetComponent<Transform>();
        sprit = gameObject.GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
       
    

	}


    void Update()
    {
        if (!isDeath) this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        else this.transform.Translate(Vector3.down * 0.6f * speed * Time.deltaTime);
        if (trans.position.y < endY)
        {
            Destroy(gameObject);
        };
        //敌人死亡动画处理
        if (isDeath)
        {
            box.enabled = false;
            timer += Time.deltaTime;
            int frameIndex = (int)(timer * frame * 0.7f);
           
            if (frameIndex >= deathSprites.Length)
            {
                Destroy(this.gameObject);
            }
            else
            {
                sprit.sprite = deathSprites[frameIndex];
                
            }


        }
        //处理敌人受伤动画
        if (isHurt)
        {
            sprit.sprite = hurtSprites[0];
            timer += Time.deltaTime;
            if (timer > 0.023f)
            {
                sprit.sprite = hurtSprites[1];
                timer = 0;
            }

            
            isHurt = false;


        }
        else
        {
            if (sprit.sprite == hurtSprites[0])
            {
                timer += Time.deltaTime;
                if (timer > 0.08f)
                {
                    sprit.sprite = hurtSprites[1];
                }
            }


        }

    }
   
    public void beHit()
    {
        Hp -= 1;
        if (Hp <= 0)
        {
            toDie();
        }
        else
        {
            isHurt = true;
        }

    }
    public void toDie()
    {
        if (!isDeath)
        {
            isDeath = true;
            GameManager._instance.score += score;
            deathMusic.Play();
        }
       
    }
   
}
