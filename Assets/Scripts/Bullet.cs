using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start(){
        Destroy(gameObject, 4f);
    }

    private void OnCollisionEnter(Collision collision){
        
            Destroy(gameObject);
        
    }
}
