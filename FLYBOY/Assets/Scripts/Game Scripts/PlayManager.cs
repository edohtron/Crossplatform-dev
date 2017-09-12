using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{

    bool start = true;
    public Text timer;
    float Timer = 5.0f;
    public GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerMortality();
        if (start)
        {
            StartCoroutine("startTimer");
        }
        if(!start)
        {
            timer.enabled = false;
        }

    }

    IEnumerator startTimer()
    {
        Time.timeScale = 0;
        float puaseTime = (int)(Time.realtimeSinceStartup + 4);
        float timeThing = (Timer - Time.realtimeSinceStartup);
        int time = (int)timeThing;
        timer.text = time.ToString();
        while (Time.realtimeSinceStartup < puaseTime)
        {
            yield return 0;
        }
        Time.timeScale = 1;
        start = false;
    }

    void CheckPlayerMortality()
    {
        if (player.GetComponent<PlayerHealth>().livesDisplay.text == "x0")
        {
            Time.timeScale = 0;
            timer.enabled = true;
            timer.text = "You lose, Loser";
        }
    }
}
