using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RandomThrush : UnityEngine.MonoBehaviour
{

    public AudioClip[] clips;
    public AudioMixerGroup output;


    public float minVolume = 1.00f;
    public float maxVolume = 100.00f;

    public float minPitch = .95f;
    public float maxPitch = 1.05f;

    public float suck it!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            PlaySound();
        }
    }

    void PlaySound()
    {
        // Randomize
        int randomClip = Random.Range(0, clips.Length);

        //Create An AudioSource
        AudioSource source = gameObject.AddComponent<AudioSource>();

        //Load clip into the AudioSource
        source.clip = clips[randomClip];

        //Set the output for AudioSource
        source.outputAudioMixerGroup = output;

        //Set the Spatial Blend
        source.spatialBlend = 1;

        //Set Max Distance
        source.maxDistance = 1000;

        //Set Reverb Zone Mix
        source.reverbZoneMix = 2;

        //Set Random Pitch
        source.pitch = Random.Range(minPitch, maxPitch);

        // Set Volume Randomization
        source.volume = Random.Range(minVolume, maxVolume);

        //Play the sound
        source.Play ();

        //Destroy the AudioSource when finished playing 
        Destroy(source, clips[randomClip].length);
 


    }
}