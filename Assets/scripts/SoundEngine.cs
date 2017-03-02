using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class SoundEngine : MonoBehaviour
{
    public AudioSource Explosion { get; private set; }
    public AudioSource Shot { get; private set; }
    public AudioSource Song { get; private set; }

    public

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        Song = audioSources[0];
        Shot = audioSources[1];
        Explosion = audioSources[2];

        //Song.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
