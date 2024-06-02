using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class sesdegerıscrıpt : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider sesslider;
    void Start()
    {
        sesslider.value = PlayerPrefs.GetFloat("sesdegeri");

    }
    
    public void sesdegeri(float volume)
    {
        audioMixer.SetFloat("volume" , volume);
        PlayerPrefs.SetFloat("sesdegeri", sesslider.value);
    }
}
