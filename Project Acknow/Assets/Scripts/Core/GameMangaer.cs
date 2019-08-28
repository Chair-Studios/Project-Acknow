using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class GameMangaer : MonoBehaviour
{
	public GameObject menuCanvas;
    public AudioMixerGroup GeneralMixer;
	public static GameMangaer instance;
	bool InMenu;
    public Slider audioSlier;
	public Dropdown dropdown;

	/*private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
	}
	*/

	private void Awake()
	{
		FindObjectOfType<AudioManager>().RePopulate(GeneralMixer, audioSlier);

	}


	public void PopulateList(List<string> BMusic)
	{
		dropdown.AddOptions(BMusic);
	}

    public void AudioSlider (float volume)
    {
        FindObjectOfType<AudioManager>().Volume(volume);
    }

    private void Update()
	{
        //Debug.Log("Menu");
        if (Input.GetKeyDown(KeyCode.Escape))
		{
           

            if (InMenu == false)
			{
				InMenu = true;
				menuCanvas.SetActive(true);
			}
			else
			{
				InMenu = false;
				menuCanvas.SetActive(false);

			}

			
		}

	}

	public void Quit()
	{
		Application.Quit();
	}
}
