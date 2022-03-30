using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public enum SoundEffect
    {       
        BackgroundMusic,
        Jump
    }

    public static AudioController instance;
    public AudioSource jumpSFX;
    public AudioSource backGroundMusic;

    public void Awake()
    {
        instance = this;
    }

    public void PlaySFX(SoundEffect a)
    {
        switch (a)
        {
            case (SoundEffect.Jump):
                jumpSFX.Play();
                break;
        }
    }
    public void PlayBackgroundMusic(SoundEffect a)
    {
        switch (a)
        {
            case SoundEffect.BackgroundMusic:
                backGroundMusic.Play();
                break;
        }
    }
}
