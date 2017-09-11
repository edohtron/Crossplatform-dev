using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class BulletShootScript : MonoBehaviour
{
    // drag 'n' drop
    public GameObject bulletPrefab;
    public Transform bulletSpawn1;
    public Transform bulletSpawn2;

    // bullet attributes
    public int bulletSpeed = 6;
    public float bulletLifeTime = 2.0f;

    // fire rate stuff
    private float coolDown = 0;
    public float fireRate = 0.05f;

    new AudioSource audio;
    public float pitchRange = 0.1f;


    // Use this for initialization
    void Start()
    {
        // Slow rate of fire.
        // Initiate Timer to 0.1 seconds or whatever.
        // Initiate bool has IsOnCoolDown to false.
        // Calling Fire() sets IsOnCoolDown to true and Timer starts.
        // Fire() cannot be called again until IsOnCoolDown is false.
        // When Timer runs out, IsOnCoolDown is set to false, and Timer resets to 0.
        // Audio
        audio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        // Shoots bullets when "Fire1" input is given.
        if ((Input.GetAxis("Jump") > 0) || CnInputManager.GetButton("Jump"))
        {

            Fire();

        }

        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            coolDown = 0;
        }

    }

    void Fire()
    {
        if (coolDown == 0)
        {

            audio.pitch = 1;
            // Create the bullets from the Bullet prefab.
            var bullet1 = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn1.position,
                bulletSpawn1.rotation) as GameObject;

            var bullet2 = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn2.position,
                bulletSpawn2.rotation) as GameObject;

            // Play the fire sound.
             
            audio.pitch += Random.Range(pitchRange, -pitchRange);
            audio.Play();

 
            // Add velocity to the bullets.
            bullet1.GetComponent<Rigidbody>().velocity = bullet1.transform.forward * bulletSpeed;
            bullet2.GetComponent<Rigidbody>().velocity = bullet2.transform.forward * bulletSpeed;

            // Resets cooldown.
            coolDown = fireRate;

            // Destroy the bullets after 2 seconds.
            Destroy(bullet1, bulletLifeTime);
            Destroy(bullet2, bulletLifeTime);
        }

    }
}
