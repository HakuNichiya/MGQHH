using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSlider : MonoBehaviour
{
    public bool Sound;
    public bool Music;
    public bool Textskipping;
    public SettingsData SD;
    public void Start()
    {
        if (Sound)
        {
            GetComponent<Slider>().value = SD.MS.Sound;
        }
        else if (Music)
        {
            GetComponent<Slider>().value = SD.MS.Music;
        }
        else if (Textskipping)
        {
            GetComponent<Slider>().value = SD.MS.Textskipping;
        }
    }
}
