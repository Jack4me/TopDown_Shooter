using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageByCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if (collision.rigidbody){
            if (collision.rigidbody.GetComponent<Bullet>()){
               gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
            }
        }
    }
}
