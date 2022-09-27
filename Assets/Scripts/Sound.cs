using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    [Range(.1f, 3f)]
    public float volume;
    [Range(0, 1)]
    public float pitch;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
    public AudioClip clip;
}
