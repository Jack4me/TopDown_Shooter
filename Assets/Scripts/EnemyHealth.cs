using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    [SerializeField] private int health;

    public void TakeDamage(int damage){
        health -= damage;
        if (health<= 0){
            Die();
        }
    }

    public void Die(){
        Destroy(gameObject);
    }
}
