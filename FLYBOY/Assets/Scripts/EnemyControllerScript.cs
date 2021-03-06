﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllerScript : MonoBehaviour {


    // Enemies are spawned by the EnemySpawnControllerScript.

    public float enemyMoveSpeed;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindWithTag("Player");
        enemyMoveSpeed = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();   
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerHealth>().takeDamage(10.0f);
 
            Destroy(this.gameObject);
        }
    }

    public virtual void Move()
    {
        // Look at the player.
        transform.LookAt(player.transform.position);

        // Move towards the player.
        transform.position += transform.forward * enemyMoveSpeed * Time.deltaTime;
    }


}
