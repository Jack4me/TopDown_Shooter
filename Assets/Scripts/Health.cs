using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField] private int health = 5;
    private int maxHealth = 10;


    public void TakeDamage(int damage){
        health -= damage;
        if (health <= 0){
            if (CompareTag("Enemy")){
                Die();
            }
        }
    }

    public void AddHealth(int healthAdd){
        health += healthAdd;
        if (health == maxHealth){
            health = maxHealth;
        }
    }


    public void Die(){
        Destroy(gameObject);
        Debug.Log("Died");
    }
}