using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour {
    public Transform target;
    public float rate;

    void LateUpdate(){
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * rate);
    }
}