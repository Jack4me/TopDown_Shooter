using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
        void Update()
        {
            //Get the Screen positions of the object
            Vector3 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

            //Get the Screen position of the mouse
            Vector3 mouseOnScreen = (Vector3)Camera.main.ScreenToViewportPoint(Input.mousePosition);

            Debug.Log("positionOnScreen" + positionOnScreen);
            Debug.Log("mouseOnScreen" + mouseOnScreen);
            // //Get the angle between the points
            // float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
            //
            // //Ta Daaa
            // transform.rotation = Quaternion.Euler(new Vector3(0f, angle, 0f));
        }

        float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
        {
            return Mathf.Atan2(a.z - b.z, a.x - b.x) * Mathf.Rad2Deg;
        }
    
}