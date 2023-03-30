using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour {
    [SerializeField] private float rateRotation;
    [SerializeField] private float runSpeed = 8;
    [SerializeField] private float walkSpeed = 5;
    private Quaternion targetRotation;
    private CharacterController controller;
    private Transform targetPlayer;
    private Rigidbody rbEnemy;

    void Start(){
        targetPlayer = FindObjectOfType<PlayerArmory>().GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
        if (CompareTag("Player")){
            gameObject.AddComponent<CharacterController>();
        }
    }

    void Update(){
        if (CompareTag("Player")){
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            if (input != Vector3.zero){
                targetRotation = Quaternion.LookRotation(input);
                transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,
                    targetRotation.eulerAngles.y,
                    rateRotation * Time.deltaTime);
            }

            Vector3 motion = input;

            motion *= (Input.GetButton("Run")) ? runSpeed : walkSpeed;
            motion += Vector3.up * -8f;
            controller.Move(motion * Time.deltaTime);
        }

        if(CompareTag("Enemy"))
        {
            transform.position += Time.deltaTime * runSpeed * transform.forward;

            Vector3 toRpalyer = targetPlayer.position - transform.position;
            Quaternion rotationToPlayer = Quaternion.LookRotation(toRpalyer, Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationToPlayer, Time.deltaTime * rateRotation);
        }
    }
}