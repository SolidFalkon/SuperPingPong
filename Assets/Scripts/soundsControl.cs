using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundsControl : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void SetSoundLvl()
    {
        
         if (SoundButton.Sound == true)
          {
              masterMixer.SetFloat("SoundsEffects", -80);
          }
          else
          {
              masterMixer.SetFloat("SoundsEffects", 0);
          }
    }
}
