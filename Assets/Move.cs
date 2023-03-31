using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour {
    [SerializeField] private float rateRotation;
    [SerializeField] private float runSpeed = 8;
    [SerializeField] private float walkSpeed = 5;
    [SerializeField] private float speed = 5;
    private Quaternion targetRotation;
    private CharacterController controller;
    private Transform target;
    private Rigidbody rbEnemy;

    private Camera cam;

    void Start(){
        target = FindObjectOfType<PlayerArmory>().GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
        if (CompareTag("Player")){
            gameObject.AddComponent<CharacterController>();
        }

        cam = Camera.main;
    }

    void Update(){
        if (CompareTag("Player")){
            Vector3 mousePosition = Input.mousePosition;
            mousePosition =
                cam.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y,
                    cam.transform.position.y - target.position.y));
            targetRotation = Quaternion.LookRotation(mousePosition - new Vector3(transform.position.x, 0, transform.position.z));
            transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,
                targetRotation.eulerAngles.y,
                rateRotation * Time.deltaTime);
            Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            Vector3 motion = input;
            motion *= (Input.GetButton("Run")) ? runSpeed : walkSpeed;
            motion += Vector3.up * -8f;
            controller.Move(motion * Time.deltaTime);
        }


        //PlayerMoveWASD();
        // EnemyMove();
    }

    public void PlayerMoveWASD(){
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
    }


    public void EnemyMove(){
        if (CompareTag("Enemy")){
            transform.position += Time.deltaTime * speed * transform.forward;

            Vector3 toTarget = target.position - transform.position;
            Quaternion rotationToPlayer = Quaternion.LookRotation(toTarget, Vector3.forward);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationToPlayer, Time.deltaTime * rateRotation);
        }
    }
}