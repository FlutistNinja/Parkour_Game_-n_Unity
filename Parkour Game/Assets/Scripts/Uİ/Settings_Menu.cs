using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings_Menu : MonoBehaviour
{
    public AudioMixer audiomix;

    private bool ŬsFullscreen = true;

    public void SetResoulation(int index)
    {
        if(index == 0)
        {
            Screen.SetResolution(1920, 1080 , ŬsFullscreen);
        }else if(index == 1)
        {
            Screen.SetResolution(1360, 768, ŬsFullscreen);
        }else if (index == 2)
        {
            Screen.SetResolution(800, 600, ŬsFullscreen);
        }
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool fullscreen_enable)
    {
        Screen.fullScreen = fullscreen_enable;
        ŬsFullscreen = fullscreen_enable;
    }

    public void SetMouseSensitivity(float value)
    {
        PlayerPrefs.SetFloat("MouseSensitivity", value);

        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().mouseSensitivity = value;
        }
    }
     
    public void SetMasterVolume(float value)
    {
        audiomix.SetFloat("MasterVolume", value);
    }

    public void SetMusicVolume(float value)
    {
        audiomix.SetFloat("MusicVolume", value);
    }

}
