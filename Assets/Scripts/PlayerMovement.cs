using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody playerRB;
    public float moveSpeed;
    public float friction;
    private void FixedUpdate(){
        playerRB.AddForce(Input.GetAxis("Horizontal") * moveSpeed, 0, 0, ForceMode.VelocityChange);
        playerRB.AddForce(-playerRB.velocity.x * friction, 0, 0, ForceMode.VelocityChange);
        
        
        playerRB.AddForce(0, 0, Input.GetAxis("Vertical") * moveSpeed, ForceMode.VelocityChange);
        playerRB.AddForce(0, 0, -playerRB.velocity.z * friction, ForceMode.VelocityChange);
    }
}