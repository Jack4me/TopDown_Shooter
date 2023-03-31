using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCubeDestroyerSasha : MonoBehaviour {
    private Move _move;
    
    void Awake(){
        _move = GetComponent<Move>();
        // _move.SetDestinationPoint(new Vector3(14, 88, 228));
    }

    private void Update(){
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _move.SetDirection(input, true);
    }
}