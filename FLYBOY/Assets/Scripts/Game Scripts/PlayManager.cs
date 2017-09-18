using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class PlayManager : MonoBehaviour
{

    bool start = true;
    public Text timer;
    float Timer = 5.0f;
    public GameObject player;
    int planet;
    public Material[] mats;
    public GameObject world;
    GameObject blr;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        blr = GameObject.FindGameObjectWithTag("Choice");
    }

    // Use this for initialization
    void Start()
    {
        if (blr != null)
        {
            planet = blr.GetComponent<ChoosePlanetScript>().choiceNo;
            Destroy(GameObject.FindGameObjectWithTag("Choice"));

        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerMortality();
        if (start)
        {
            StartCoroutine("startTimer");
        }
        if (!start)
        {
            timer.enabled = false;
        }

        switch (planet)
        {
            case 1:

                break;
            case 2:
                world.GetComponent<MeshRenderer>().material = mats[1];
                break;
            case 3:
                world.GetComponent<MeshRenderer>().material = mats[0];
                break;

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
