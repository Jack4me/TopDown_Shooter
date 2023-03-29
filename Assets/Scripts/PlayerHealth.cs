using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health = 5;
    public int maxHealth = 10;


    public void TakeDamage(int damage){
        health -= damage;
        if (health <= 0){
            Die();
        }
    }

    public void AddHealth(int healthAdd){
        health += healthAdd;
    }


    public void Die(){
        Debug.Log("Player Died");
    }
}