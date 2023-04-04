using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Move _move;
    [SerializeField] private Transform targetPosition;
    private Vector3 direction;
    public float speed = 50; 
    void Awake(){
        _move = GetComponent<Move>();
        
    }

    private void Update(){
        direction = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical") );

        _move.SetDirection(direction);
    }
}