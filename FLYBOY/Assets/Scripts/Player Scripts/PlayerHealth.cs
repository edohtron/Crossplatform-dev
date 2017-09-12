using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    //hp 
    public float startHP = 100.0f;
    public float currentHP;
    public Image healthBar;
    public Text HPdisplay;

    //life count
    private int livesRemaining;
    public Text livesDisplay;
    bool isDead;

    
    //score
    private int score;
    public Text scoreDisplay;

  
    public Transform spawnPos;
    public GameObject notificationPanel;

	// Use this for initialization
	void Start() {

        currentHP = startHP;
        livesRemaining = 5;
        //notificationPanel.SetActive(false);
        	
	}

    // Update is called once per frame
    void Update() {
        
       if (currentHP <= 0 && livesRemaining > 0)
       {
            onDeath();
       }

       else if (livesRemaining == 0)
       {
            notificationPanel.SetActive(true);
            //set game over state
       }
       
       //update gui elements
       healthBar.fillAmount = currentHP / 100.0f;
       HPdisplay.text = currentHP.ToString("F0") + "%";
       livesDisplay.text = "x" + livesRemaining.ToString();
       scoreDisplay.text = "Score: " + score.ToString();
        
	}

    public void takeDamage(float damage)
    {
        currentHP -= damage;
    }

    public void addScore(int sc)
    {
        score += sc;
    }

    private void onDeath()
    {
        currentHP = 100.0f;
        gameObject.transform.position = spawnPos.position;
        livesRemaining -= 1;
        
    }

}
