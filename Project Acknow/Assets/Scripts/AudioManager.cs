using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public Sound[] sounds;

	private string[] BackGroundThemes;

	public static AudioManager instance;

	

	void Awake ()
	{

		if(instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();

			s.source.clip = s.clip;

			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;

			if (s.BackGroundMusic == true)
			{
				BackGroundThemes[BackGroundThemes.Length + 1] = s.name;
			}
		}
	}

	System.Random rand = new System.Random();

	private void Start()
	{
		Play(BackGroundThemes[rand.Next(0, BackGroundThemes.Length)]);
		Debug.Log(BackGroundThemes[rand.Next(0, BackGroundThemes.Length)]);
	}

	public void Play (string name)
	{
		Sound s = System.Array.Find(sounds, sound => sound.name == name);

		if(s == null)
		{
			Debug.LogWarning("Sound: " + name + " has not been found. Check spelling.");
			return;
		
		}
		s.source.Play();

	}

}
