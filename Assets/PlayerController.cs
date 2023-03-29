using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {
    public float rateRotation;
    public float runSpeed = 8;
    public float walkSpeed = 5;
    private Quaternion targetRotation;
    private CharacterController controller;

    void Start(){
        controller = GetComponent<CharacterController>();
    }

    void Update(){
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (input != Vector3.zero){
            targetRotation = Quaternion.LookRotation(input);
            transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y,
                                        rateRotation * Time.deltaTime);
        }

        Vector3 motion = input;
        
        motion *= (Input.GetButton("Run")) ? runSpeed : walkSpeed;
        motion += Vector3.up * -8f;
        controller.Move(motion * Time.deltaTime);
    }
}