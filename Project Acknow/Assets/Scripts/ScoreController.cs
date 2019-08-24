using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{   
    public Text txt;
    float score = 0f;

    void Start()
    {
        txt.text = "Coins: " + score.ToString();        
    }

    public void Points (float pts)
	{
		score += pts;
        txt.text = "Coins: " + score.ToString();
        Debug.Log(pts);
    }

}
