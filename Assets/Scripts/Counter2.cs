using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter2 : MonoBehaviour
{
    private SpawnController spawnController;

    void Start(){
        spawnController = GameObject.Find("SpawnController").GetComponent<SpawnController>();

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Trailer")){
            spawnController.Count += 1;
            spawnController.CounterText.text = "Count : " + spawnController.Count;
        }
    }

    
}
