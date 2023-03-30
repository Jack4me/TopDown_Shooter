using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(Rigidbody))]
public class CreateEnemies : MonoBehaviour {
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private Transform[] spawn;

    private void Start(){
        for (int i = 0; i < enemies.Length; i++){
            Transform randomPosition = spawn[Random.Range(0, spawn.Length)];
            Instantiate(enemies[i], randomPosition);
        }
    }
}
