using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMangaer : MonoBehaviour
{
	public GameObject menuCanvas;

	public static GameMangaer instance;
	bool InMenu;

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
		FindObjectOfType<AudioManager>().Populate();
	}


	public void PopulateList(List<string> BMusic)
	{
		dropdown.AddOptions(BMusic);
	}

	private void Update()
	{
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
