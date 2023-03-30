using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageByCollision : MonoBehaviour {
    

    private void OnCollisionEnter(Collision collision){
        if (collision.rigidbody){
            if (collision.rigidbody.GetComponent<Health>()){
                collision.rigidbody.GetComponent<Health>().TakeDamage(1);
            }
        }
    }
}