using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour {
   public Transform targetPlayer;
   public Rigidbody rbEnemy;
   public float speed;
   public float rotationSpeed;

   private void Start(){
       targetPlayer = FindObjectOfType<PlayerHealth>().transform;
   }

   private void Update(){
       transform.position += Time.deltaTime * speed * transform.forward;

         Vector3 toRpalyer = targetPlayer.position - transform.position;
         Quaternion rotationToPlayer = Quaternion.LookRotation(toRpalyer, Vector3.forward);
         transform.rotation = Quaternion.Lerp(transform.rotation, rotationToPlayer, Time.deltaTime * rotationSpeed);
      }
}
