using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour {
    [SerializeField] private float speed;


    public void SetDestinationPoint(Vector3 destination){
        transform.position = destination;
    }

    public void SetDirection(Vector3 dir, bool Active){
        if (Active == true){
            transform.position += dir * speed * Time.deltaTime;
        }

        if (Active == false){
            Vector3 toTarget = dir - transform.position;
            transform.position += toTarget * speed * Time.deltaTime;
        }
    }
}