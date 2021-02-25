using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource menuSound;
    public GameObject settingsMenu;

    public void PVP()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("LvlPvp");
    }
    public void PVE()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("LvlPve");
    }
    public void Exit()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        Application.Quit();
    }
    public void Settings()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        settingsMenu.SetActive(true);
    }
    public void close()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        settingsMenu.SetActive(false);
    }

}
