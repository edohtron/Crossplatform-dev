using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterControllerScript : EnemyControllerScript
{


    // Enemies are spawned by the EnemySpawnControllerScript.

    // Movement stuff
    //public float moveSpeed = enemyMoveSpeed;
    //GameObject player = null;
    public float dist = 0;
    public float attackRange = 0;

    // Firing stuff
    public GameObject bulletPrefab = null;
    public Transform bulletSpawn = null;
    public float fireRate = 2.0f;
    private float coolDown = 0;
    public float bulletSpeed = 50f;

    // audio stuff
    new AudioSource audio;
    public float pitchRange = 0.1f;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        dist = transform.position.z - player.transform.position.z;

        // if distant from player, move towards them.
        if (dist >= attackRange)
        {
            Move();
        }
        // if within range, stop moving and shoot at player.
        else if (dist <= attackRange)
        {
            Fire();
        }

        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            coolDown = 0;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //player.GetComponent<PlayerMovement>().health -= 10;
            Destroy(this.gameObject);
        }
    }

    public override void Move()
    {
        // Look at the player.
        transform.LookAt(player.transform.position);

        // Move towards the player.
        transform.position += transform.forward * enemyMoveSpeed * Time.deltaTime;
    }

    void Fire()
    {
        // Look at the player.
        transform.LookAt(player.transform.position);
        if (coolDown == 0)
        {
            // resets the pitch.
            audio.pitch = 1;
            // creates the bullet.
            Instantiate<GameObject>(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);

            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn.position,
                bulletSpawn.rotation) as GameObject;
            // alters the pitch a bit.
            audio.pitch += Random.Range(pitchRange, -pitchRange);
            // plays the fire sound.
            audio.Play();

            // Add velocity to the bullets.
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

            // resets the cooldown so we can control the fire rate.
            coolDown = fireRate;
        }



    }
}
