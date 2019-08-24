using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTextController : MonoBehaviour
{

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void win()
    {
        txt.text = "You won!!!!!!!!!!!";
        UnityEngine.SceneManagement.SceneManager.LoadScene("scene");
    }
}
