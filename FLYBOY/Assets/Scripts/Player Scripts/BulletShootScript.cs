using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShootScript : MonoBehaviour
{
    // drag 'n' drop
    public GameObject bulletPrefab;
    public Transform bulletSpawn1;
    public Transform bulletSpawn2;
    public Transform parent;

    // bullet attributes
    public int bulletSpeed = 6;
    public float bulletLifeTime = 2.0f;

    // fire rate stuff
    private float coolDown = 0;
    public float fireRate = 0.05f;


    // Use this for initialization
    void Start()
    {
        // Slow rate of fire.
        // Initiate Timer to 0.1 seconds or whatever.
        // Initiate bool has IsOnCoolDown to false.
        // Calling Fire() sets IsOnCoolDown to true and Timer starts.
        // Fire() cannot be called again until IsOnCoolDown is false.
        // When Timer runs out, IsOnCoolDown is set to false, and Timer resets to 0.		


    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Fire1") > 0))
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
            // Create the bullets from the Bullet prefab.
            var bullet1 = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn1.position,
<<<<<<< HEAD
                bulletSpawn1.rotation);
            bullet1.transform.parent = parent;
=======
                bulletSpawn1.rotation) as GameObject;
            bullet1.transform.SetParent(parent);
>>>>>>> 067826084138282c93748085132564267b59eb73

            var bullet2 = (GameObject)Instantiate(
                bulletPrefab,
                bulletSpawn2.position,
<<<<<<< HEAD
                bulletSpawn2.rotation);
            bullet2.transform.parent = parent;
=======
                bulletSpawn2.rotation) as GameObject;
            bullet2.transform.SetParent(parent);
>>>>>>> 067826084138282c93748085132564267b59eb73

            // Add velocity to the bullets.
            //bullet1.GetComponent<Rigidbody>().velocity = bullet1.transform.forward * bulletSpeed;
            //bullet2.GetComponent<Rigidbody>().velocity = bullet2.transform.forward * bulletSpeed;

            // Resets cooldown.
            coolDown = fireRate;

            // Destroy the bullets after 2 seconds.
            Destroy(bullet1, bulletLifeTime);
            Destroy(bullet2, bulletLifeTime);
        }

    }
}
