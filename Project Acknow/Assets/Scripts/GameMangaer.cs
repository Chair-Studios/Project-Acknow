﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangaer : MonoBehaviour
{
	public GameObject menuCanvas;
	public static GameMangaer instance;
	bool InMenu;

	private void Awake()
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
