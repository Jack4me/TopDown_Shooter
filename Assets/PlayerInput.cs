using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour {
    public float speed;
    private Vector2 directionMove, mouseLook, joystickLook;
    private Vector3 rotationTarget;
    public bool isPC;
    private Move move;

    private void Awake(){
        move = GetComponent<Move>();
    }

    public void MoveOn(InputAction.CallbackContext context){
        directionMove = context.ReadValue<Vector2>();
    }

    public void mouseLookOn(InputAction.CallbackContext context){
        mouseLook = context.ReadValue<Vector2>();
    }

    public void joystickLookOn(InputAction.CallbackContext context){
        joystickLook = context.ReadValue<Vector2>();
    }

    void Update(){
        if (isPC){
            Ray ray = Camera.main.ScreenPointToRay(mouseLook);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)){
                rotationTarget = hit.point;
            }

            movePlayerInDirection();
        }
        else{
            if (joystickLook.x == 0 && joystickLook.y == 0)
                PlayerMove();
            else{
                movePlayerInDirection();
            }
        }
    }

    public void PlayerMove(){
        Vector3 movement = new Vector3(directionMove.x, 0f, directionMove.y);

        if (movement != Vector3.zero){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        }
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

    public void movePlayerInDirection(){
        if (isPC){
            var lookPos = rotationTarget - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            Vector3 aimDirection = new Vector3(rotationTarget.x, 0f, rotationTarget.z);
            if (aimDirection != Vector3.zero){
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.15f);
            }
        }
        else{
            Vector3 aimDirection = new Vector3(joystickLook.x, 0f, joystickLook.y);
            if (aimDirection != Vector3.zero){
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(aimDirection), 0.15f);
            }
        }

        Vector3 movement = new Vector3(directionMove.x, 0f, directionMove.y);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}