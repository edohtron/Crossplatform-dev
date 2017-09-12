using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerScript : MonoBehaviour {


	// Use this for initialization
	void Start ()

    GameObject player;


    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter()
    {
        Destroy(gameObject);

        if(col.gameObject.tag == "Enemy")
        {
            player.GetComponent<PlayerHealth>().addScore(2);

            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
