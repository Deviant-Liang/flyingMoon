using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSourceController : MonoBehaviour
{

    public AudioSource Music;
    public AudioSource SoundEffect;


    public bool BGM;
    public bool SFX;


    public Text BGMTxt;
    public Text SFXTxt;


    void Start()
    {
        if (SaveManager.instance.BGM == false)
        {
            BGMTxt.text = "Music: Off";
            Music.Pause();
        }
        else
        {
            BGMTxt.text = "Music: On";
            Music.Play();
        }

        if (SaveManager.instance.SFX == false)
        {
            SFXTxt.text = "SFX: Off";
            SoundEffect.enabled = false;
        }
        else
        {
            SFXTxt.text = "SFX: On";
            SoundEffect.enabled = true;
        }
    }

    public void BGMBt()
    {
        if (SaveManager.instance.BGM == true)
        {
            BGMTxt.text = "Music: Off";
            Music.Pause();
        }
        else
        {
            BGMTxt.text = "Music: On";
            Music.Play();
        }

        BGM = SaveManager.instance.BGM;
        SaveManager.instance.BGM = !BGM;
        SaveManager.instance.Save();

    }

    public void SFXBt()
    {
        if (SaveManager.instance.SFX == true)
        {
            SFXTxt.text = "SFX: Off";
            SoundEffect.enabled = false;

        }
        else
        {
            SFXTxt.text = "SFX: On";
            SoundEffect.enabled = true;
        }
        SFX = SaveManager.instance.SFX;
        SaveManager.instance.SFX = !SFX;
        SaveManager.instance.Save();

    }
}
