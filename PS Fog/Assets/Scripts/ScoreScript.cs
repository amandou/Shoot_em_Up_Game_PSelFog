﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public static float score;

    void Start()
    {
        scoreText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ""+score;
    }

}
