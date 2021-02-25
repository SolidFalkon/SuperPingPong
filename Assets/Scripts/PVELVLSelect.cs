using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PVELVLSelect : MonoBehaviour
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
        SceneManager.LoadScene("PingPongLvl1");
    }
    public void LVL2()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl2");
    }
    public void LVL3()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl3");
    }
    public void LVL4()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl4");
    }
    public void LVL5()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("PingPongLvl5");
    }
}
