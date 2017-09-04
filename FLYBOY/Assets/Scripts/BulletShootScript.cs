using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootScript : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn1;
    public Transform bulletSpawn2;

    public int bulletSpeed = 6;
    public float bulletLifeTime = 2.0f;

    // Use this for initialization
    void Start ()
    {
       // Slow rate of fire.
       // Initiate Timer to 0.1 seconds or whatever.
       // Initiate bool has IsOnCoolDown to false.
       // Calling Fire() sets IsOnCoolDown to true and Timer starts.
       // Fire() cannot be called again until IsOnCoolDown is false.
       // When Timer runs out, IsOnCoolDown is set to false, and Timer resets to 0.		

       
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetAxis("Fire1") > 0)
        {

            Fire();
        }
	}

    void Fire()
    {
        // Create the bullets from the Bullet prefab.
        var bullet1 = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn1.position,
            bulletSpawn1.rotation);
        var bullet2 = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn2.position,
            bulletSpawn2.rotation);

        // Add velocity to the bullets.
        bullet1.GetComponent<Rigidbody>().velocity = bullet1.transform.forward * bulletSpeed;
        bullet2.GetComponent<Rigidbody>().velocity = bullet2.transform.forward * bulletSpeed;

        // Destroy the bullets after 2 seconds.
        Destroy(bullet1, bulletLifeTime);
        Destroy(bullet2, bulletLifeTime);
    }
}
