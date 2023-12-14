using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public Sound[] musicSounds, effectSounds;
    public AudioSource musicSource, effectSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SoundManager.Instance.PlayMusic("MenuTheme");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Music not found: " + name);
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlayEffect(string name)
    {
        Sound s = Array.Find(effectSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Music not found: " + name);
        }

        else
        {
            effectSource.PlayOneShot(s.clip);
        }

    }
}
