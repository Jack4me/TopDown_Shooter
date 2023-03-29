using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LootGun : MonoBehaviour {
    public int gunIndex = 1;
    public int amountBullets = 10;
    private void OnTriggerEnter(Collider other){
        if (other.attachedRigidbody.GetComponent<PlayerArmory>()){
            other.attachedRigidbody.GetComponent<PlayerArmory>().AddBullets(gunIndex, amountBullets);
            Destroy(gameObject);
        }
    }
}
