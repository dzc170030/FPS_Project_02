﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    AudioSource _audioSource;

    private void Awake()
    {
        #region Singleton Pattern (Simple)
        if(Instance == null)
        {
            // doesn't exist yet, this is now our singleton!
            Instance = this;
            DontDestroyOnLoad(gameObject);
            //fill references
            _audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySong(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
