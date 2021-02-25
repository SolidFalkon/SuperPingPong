using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public static bool Sound = true;
    public Sprite soundOff;
    public Sprite soundOn;

    void Start()
    {
        if (Sound == true)
        {
            GetComponent<Image>().sprite = soundOn;
        }
        else
        {
            GetComponent<Image>().sprite = soundOff;
        }
    }

    public void OnClickSound()
    {
        if (Sound == true)
        {
            GetComponent<Image>().sprite = soundOff;
            Sound = false;
        }
        else
        {
            GetComponent<Image>().sprite = soundOn;
            Sound = true;
        }
    }
}
