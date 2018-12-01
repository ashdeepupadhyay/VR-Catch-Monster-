﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour,IPointerExitHandler,IPointerEnterHandler {
    public float gazeTime = 2f;
    private float timer = 0f;
    private bool gazedAt = false;
    public bool daynight = true;

    private const string day = "DayScene";
    private const string night = "NightScene";
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                ChangeScene(daynight);                
                timer = 0f;
            }

        }
    }
    public void ChangeScene(bool checkdaynight)
    {
        if(checkdaynight)
        {
            SceneManager.LoadScene(day);
        }
        else
        {
            SceneManager.LoadScene(night);
        }       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gazedAt = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("gazedat"); gazedAt = true;      
    }    
}
