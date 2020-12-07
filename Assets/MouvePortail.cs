using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvePortail : MonoBehaviour
{
 	public float speed = 10f;
	public static bool DroneTclose = false;
	private Transform target;
	private Vector3 dir;
	void Start()
	{
		target = WaysPortail.points[0];
	}
  
	 private void Update()
    	{
	    if(DroneTclose == true)
		{
			dir = target.position - transform.position;
            		transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);
		}
            
    	}
}
