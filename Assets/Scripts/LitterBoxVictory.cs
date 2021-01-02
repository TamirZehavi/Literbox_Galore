﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitterBoxVictory : MonoBehaviour
{
    [SerializeField] private PlayerController player;
    public bool isVictory = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isVictory)
        {
            Debug.Log("Win");
        }

        else
        {
            Debug.Log("no");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isVictory)
        {
            Debug.Log("Win");
        }

        else
        {
            Debug.Log("no");
        }
    }
}
