using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireDelay = 0.5f;
    private float nextFire = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireDelay;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
