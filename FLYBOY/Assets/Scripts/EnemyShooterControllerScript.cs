using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterControllerScript : MonoBehaviour
{


    // Enemies are spawned by the EnemySpawnControllerScript.

    public float enemyMoveSpeed;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //player.GetComponent<PlayerMovement>().health -= 10;
            Destroy(this.gameObject);
        }
    }

    void Move()
    {
        // Look at the player.
        transform.LookAt(player.transform.position);

        // Move towards the player.
        transform.position += transform.forward * enemyMoveSpeed * Time.deltaTime;
    }

    void Shoot()
    {

    }
}
