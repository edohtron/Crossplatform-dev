using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControllerScript : MonoBehaviour
{
    //public Rigidbody rb;
    //public Transform tr;
    //public SphereCollider col;

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

    // Destroyes itself and enemy.
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            player.GetComponent<PlayerHealth>().addScore(2);

            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
