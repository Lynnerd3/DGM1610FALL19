﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string name = "Lynnerd";
    int age = 27;
    float height = 6.2f;
    bool mStatus = false;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + name);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Maritial Status: " + mStatus);
                
    }

}
