using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHealth : MonoBehaviour {
    [SerializeField] private int countOfHealth = 1;

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            other.attachedRigidbody.GetComponent<Health>().AddHealth(countOfHealth);
            Destroy(gameObject);
        }
    }
}
