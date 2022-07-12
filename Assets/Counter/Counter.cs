﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(gameObject.CompareTag("Ball")){
            Count += 1;
            CounterText.text = "Count : " + Count;
        }
    }

    
}
