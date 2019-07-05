using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    static bool AudioBegin = false;
    public AudioSource gameMusic;

    void Awake()
    {
        if (!AudioBegin)
        {
            gameMusic = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}
