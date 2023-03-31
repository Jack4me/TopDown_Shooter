using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Move _move;
    [SerializeField] private Transform targetPosition;
    void Awake(){
        _move = GetComponent<Move>();
    }
    void Update()
    {
        _move.SetDirection(targetPosition.position, false);
    }
}
