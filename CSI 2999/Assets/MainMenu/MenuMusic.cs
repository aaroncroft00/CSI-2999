using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMusic : MonoBehaviour
{
public AudioSource AudioSource;
public float musicVolume;
public Slider volumeSlider;


public void Start()
{
    //Starts music
    AudioSource.Play();

    AudioSource.volume = PlayerPrefs.GetFloat("volume");
    
    volumeSlider.value = PlayerPrefs.GetFloat("volume");
}

public void updateVolume(float volume)
{
    //Sets AudioSource to slider value
    AudioSource.volume = volume;
    //Stores current volume in musicVolume
    musicVolume = volume;

    PlayerPrefs.SetFloat("volume", musicVolume);
    
}

}