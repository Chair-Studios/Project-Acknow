﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMangaer : MonoBehaviour
{
	public GameObject menuCanvas;

	public Dropdown dropdown;

	public static GameMangaer instance;
	bool InMenu;

	public void PopulateList(List<string> BMusic)
	{
		dropdown.AddOptions(BMusic);
	}

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