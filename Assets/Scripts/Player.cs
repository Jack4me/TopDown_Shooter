using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Move _move;
    private Vector3 direction;
    void Awake(){
        _move = GetComponent<Move>();
    }
    private void Update(){
        direction = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical") );

        _move.SetDirection(direction);
    }
}