using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public void Awake()
    {
        foreach (var sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
            sound.source.clip = sound.clip;
        }
    }

    public void PlayMySound(string name)
    {
        foreach (var sound in sounds)
        {
            if(sound.name == name)
            {
                sound.source.Play();
            }
            
        }
    }
}
