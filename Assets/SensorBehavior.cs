using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorBehavior : MonoBehaviour
{
 
public static bool detectedMotion = false;

    void Update()
    {
        Ray ray = new Ray(transform.position,Vector2.down);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray,out hitInfo,30)){
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            detectedMotion = true;
        }else{
            Debug.DrawLine(ray.origin, ray.origin+ray.direction*30, Color.green);
        }
    }
}

