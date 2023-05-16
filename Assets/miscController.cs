using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miscController : MonoBehaviour
{
    public EasyRecoil ER;
    private float timeDelay = .1f;
    public GameObject BulletSpawn;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && timeDelay <= 0)
        {
            timeDelay = .1f;

            GameObject newBullet =
                Instantiate(bulletPrefab, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 60, ForceMode.Impulse);
            ER.Fire();
        }

        timeDelay -= Time.deltaTime;
    }
}

