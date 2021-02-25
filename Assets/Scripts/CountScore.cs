using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;
    public int Platform_1_Score = 0;
    public int Platform_2_Score = 0;
    public bool lose = false;
    public bool win = false;
    public bool SpawnPl1 = false;
    public bool SpawnPl2 = false;

    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (win == true || FindObjectOfType<PauseMenu>().GameIsPaused == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        if (lose == true || FindObjectOfType<PauseMenu>().GameIsPaused == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        if (Platform_1_Score == 5)
        {
            win = true;
        }
        if (Platform_2_Score == 5)
        {
            lose = true;
        }
        if (ball.transform.position.x >= 10f)
        {
            Platform_1_Score++;
            SpawnPl1 = true;
        }
        if (ball.transform.position.x <= -10f)
        {
            Platform_2_Score++;
            SpawnPl2 = true;
        }
        Scoreboard.text = Platform_1_Score.ToString() + ":" + Platform_2_Score.ToString();
    }
}
