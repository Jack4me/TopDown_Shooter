using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public Transform spawnBullet;
    public GameObject bullet;
    public float speed = 10f;
    public float timer;
    public float shotRate = 0.5f;

   

    private void Update(){
        timer += Time.deltaTime;
        if (Input.GetMouseButton(0)){
            if (timer > shotRate){
                Shot();
                timer = 0;
            }
        }
    }

    public void Shot(){
        GameObject newBullet = Instantiate(bullet, spawnBullet.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = speed * spawnBullet.forward;
    }
}