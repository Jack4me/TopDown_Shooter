using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    [SerializeField] private Transform spawnBullet;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float timer;
    [SerializeField] private float shotRate = 0.5f;
   

   

    private void Update(){
        timer += Time.deltaTime;
        if (Input.GetMouseButton(0)){
            if (timer > shotRate){
                Shot();
                timer = 0;
            }
        }
    }

    public virtual void Shot(){
        GameObject newBullet = Instantiate(bulletPrefab, spawnBullet.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = speed * spawnBullet.forward;
    }

    public virtual void ActivateGun(){
        gameObject.SetActive(true);
    }

    public virtual void DeActivateGun(){
        gameObject.SetActive(false);
    }

    public virtual void AddBullets(int bullets){
    }
}