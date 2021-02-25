using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject loseMenu;
    public GameObject WinMenu;
    public GameObject SettingMenu;
    public AudioSource menuSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            {
                Pause();
            }
        }
        if (FindObjectOfType<CountScore>().lose == true)
        {
            Lose();
        }
        if (FindObjectOfType<CountScore>().win == true)
        {
            Win();
        }
    }
    public void Menu()
    {
       SceneManager.LoadScene("Menu");
    }
    public void Resume()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Next()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SceneManager.LoadScene("LvlPve");
    }
    public void Restart()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        FindObjectOfType<CountScore>().lose = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Settings()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SettingMenu.SetActive(true);
    }
    public void CloseSettings()
    {
        menuSound.pitch = Random.Range(0.9f, 1.1f);
        menuSound.Play();
        SettingMenu.SetActive(false);
    }
    void Lose()
    {
        loseMenu.SetActive(true);
    }
    void Win()
    {
        WinMenu.SetActive(true);
    }
}
