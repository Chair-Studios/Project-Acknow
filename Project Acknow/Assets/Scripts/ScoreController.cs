using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{   
    public Text txt;
    float score = 0f;
    float total = 0f;

    void Start()
    {
        txt.text = "Coins: " + score.ToString() + "/" + total;        
    }

    public void Points (float pts)
	{
		score += pts;
        txt.text = "Coins: " + score.ToString() + "/" + total;
        Debug.Log(pts);
    }

    public void Total()
    {
        total += 1;
        Debug.Log(total);
    }

    private void Update()
    {
        // load next scene
        if (score >= total)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("scene");
        }
    }
}
