﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public AudioSource efxSound;

   public static SoundManager instance = null;

   void Awake(){
       if(instance == null){
           instance = this;
       }
       else if(instance != this){
          Destroy(gameObject);
       }

       DontDestroyOnLoad(gameObject);
   }

   public void PlaySingle(AudioClip clip){
       efxSound.clip = clip;
       efxSound.Play();
   }
   public void PlayMusic(AudioClip clip){
       efxSound.clip = clip;
       efxSound.Play();
   }

   
}
