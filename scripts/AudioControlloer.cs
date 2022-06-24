using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControlloer : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource SFX;


    void Start()
    {
        if (SaveManager.instance.BGM == false)
        {
            BGM.Pause();
        }
        else
        {
            BGM.Play();
        }

        if (SaveManager.instance.SFX == false)
        {
            SFX.enabled = false;
        }
        else
        {
            SFX.enabled = true;
        }
    }

}
