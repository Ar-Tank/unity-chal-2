﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1.0f; // Time in seconds between spawns
    private float nextFire = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if enough time has passed since the last spawn
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // set next time the dog can be spawned (doggo come back :D )
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
