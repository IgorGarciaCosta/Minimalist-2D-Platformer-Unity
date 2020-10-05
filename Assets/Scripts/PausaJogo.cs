using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaJogo : MonoBehaviour
{
    public AudioClip click;
    public void pausa(){
        SoundManager.instance.PlaySingle(click);
        if(Time.timeScale==0){
            Time.timeScale = 1;
        }
        else{
            Time.timeScale = 0;
        }
    }
}
