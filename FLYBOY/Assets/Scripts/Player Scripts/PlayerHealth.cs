using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    //hp 
    public float startHP = 100.0f;
    private float currentHP;
    public Image healthBar;
    public Text HPdisplay;

    //life count
    private int livesRemaining;
    public Text livesDisplay;

    //score
    private int score;
    public Text scoreDisplay;


	// Use this for initialization
	void Start () {
        currentHP = startHP;
        livesRemaining = 10;
                	
	}

    // Update is called once per frame
    void Update() {

        //currentHP -= .5f;
        healthBar.fillAmount = currentHP / 100;

        HPdisplay.text = currentHP.ToString("F0") + "%";

        livesDisplay.text = "x" + livesRemaining.ToString();

        scoreDisplay.text = "Score: " + score.ToString();
        
	}
}
