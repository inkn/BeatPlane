using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class continueButton : MonoBehaviour
{
    public GameObject minimenue;
    public Image stop;
    public Sprite restop;
  
  
  

    public void onClick()
    {
       
        minimenue.SetActive(false);
        stop.sprite = restop;
        Time.timeScale = 1;
        buttonStop._instance.onClick();


    }
}