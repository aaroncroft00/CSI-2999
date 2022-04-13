using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource AudioSource;
    //public float musicVolume;
    
    public void updateVolume(float volume)
    {
        AudioSource.volume = volume;


        //Debug.Log(musicVolume);
    }

   // void setVolume()
   // {
       // Debug.Log(volume);
        //AudioSource.volume = musicVolume;
   // }

    
}
