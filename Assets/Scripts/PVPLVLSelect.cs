using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PVPLVLSelect : MonoBehaviour
{
    public AudioSource menuSound;

    public void Menu()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("Menu");
    }

    public void LVL1()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl1PVP");
    }
    public void LVL2()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl2PVP");
    }
    public void LVL3()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl3PVP");
    }
    public void LVL4()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl4PVP");
    }
    public void LVL5()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl5PVP");
    }
}
