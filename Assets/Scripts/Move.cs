using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour {
    [SerializeField] private float speed;
    private Transform _targetTransform;
    private Vector3 _destinationPoint;
    private Vector3 _direction;
    

    public void SetTargetFollow(Transform target){
        _targetTransform = target;
    }

    public void SetDestinationPoint(Vector3 destination){
        _destinationPoint = destination;
    }

    public void SetDirection(Vector3 dir){
        _direction = dir;
    }

    void Update(){ 
        if (_targetTransform != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetTransform.position, speed * Time.deltaTime);
        }
        if (_destinationPoint != Vector3.zero)
        {
            transform.position = Vector3.MoveTowards(transform.position, _destinationPoint, speed * Time.deltaTime);
        }
        if (_direction != Vector3.zero)
        {
            transform.position += _direction * speed * Time.deltaTime;
        }
    }
    
}

//
// public void SetDirection(Vector3 destination){
//     transform.position = destination;
// }
//
// public void SetDestinationPoint(Vector3 dir, bool Active){
//     if (Active == true){
//         transform.position += dir * speed * Time.deltaTime;
//     }
//
//     if (Active == false){
//         transform.position = Vector3.MoveTowards(transform.position, dir, Time.deltaTime * speed);
//     }
// }