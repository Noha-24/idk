
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip overworldMusic;
    public AudioClip caveMusic;

    public AudioClip[] variousSFX;

    void Awake()
    {
        // Make sure there is only one Audio Manager
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
        musicSource.clip = overworldMusic;
        musicSource.Play();
    }

    // Play a specific sound effect
    public void PlayMusicSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    // Play a specific soundtrack
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    // Play a random sound effect
    public void PlayRandomSFX(params AudioClip[] clips)
    {
        variousSFX = clips;

        if (variousSFX.Length > 0)
        {
            int index = Random.Range(0, variousSFX.Length);
            sfxSource.PlayOneShot(variousSFX[index]);
        }
    }
}
