﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Index : MonoBehaviour
{

    private Vector2 scrollViewVector = Vector2.zero;
    private string[] countrys = { "Any country", "Afghanistan", "Albania", "Algeria" };//add the rest
    int n, i, wichcountry;

    void Start()
    {
        n = 0; i = 0; wichcountry = 0;
    }

    void OnGUI()
    {

        if (GUI.Button(new Rect(125, 50, 25, 25), ""))
        {
            if (n == 0) n = 1;
            else n = 0;
        }

        if (n == 1)
        {
            scrollViewVector = GUI.BeginScrollView(new Rect(25, 50, 100, 115), scrollViewVector, new Rect(0, 0, 300, 500));
            GUI.Box(new Rect(0, 0, 300, 500), "");
            for (i = 0; i < 4; i++)
            {
                if (GUI.Button(new Rect(0, i * 25, 300, 25), ""))
                {
                    n = 0; wichcountry = i;
                }
                GUI.Label(new Rect(5, i * 25, 300, 25), countrys[i]);
            }
            GUI.EndScrollView();
        }
        else
        {
            GUI.Label(new Rect(30, 50, 300, 25), countrys[wichcountry]);
        }
    }
}