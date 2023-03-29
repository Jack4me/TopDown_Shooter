using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour {
    public Transform target;
    public float lerpRate;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * lerpRate);
    }
}
