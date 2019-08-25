using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthController : MonoBehaviour
{

    public Text txt;
    float health = 10f;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = txt.text = "Health: " + health.ToString();
    }

    public void HealthAdd(float hpts)
    {
        health += hpts;
        
        Debug.Log(hpts);

        //dead
        if (health < 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("scene");
        }

        if (health > 9)
        {
            health = 10;
        }

		txt.text = "Health: " + health.ToString();
	}

}