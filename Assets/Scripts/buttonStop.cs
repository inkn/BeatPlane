using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonStop : MonoBehaviour {
    public static buttonStop _instance;
    private Image imag;
    public Sprite stop;
    public Sprite restop;
    public GameObject minimenu;
    public bool isStop;




    
    private void Awake()
    {
        imag = this.GetComponent<Image>();
        _instance = this;
    
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            onClick();

        }
     
    }


    public void onClick()
    {
        
        if (isStop)
        {
            continnueGame();
        }else
        {
            stopGame();
        }
        
       
        
    }
    public void stopGame()
    {
        isStop = true;

       imag.sprite = stop;
        Time.timeScale = 0;
        AudioListener.pause = true;
        minimenu.SetActive(true);
      
        
       

    }
    public void continnueGame()
    {
        isStop = false;
        minimenu.SetActive(false);
        imag.sprite = restop;
        Time.timeScale = 1;
        AudioListener.pause = false;


    }
}
