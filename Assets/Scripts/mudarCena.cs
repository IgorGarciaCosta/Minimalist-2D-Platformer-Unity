using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mudarCena : MonoBehaviour
{

    public string nomeDaCena;
    //public AudioClip click;
    
    public void ChangeS(){
        //SoundManager.instance.PlaySingle(click);
        SceneManager.LoadScene(nomeDaCena);
    }

    public void SairDoJogo(){
        Application.Quit();
    }
}