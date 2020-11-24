using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Drone1Mouvement : MonoBehaviour
{
    public float speed = 1500f;
    private Transform target;
    private int waypointIndex = 0 ;
    private Vector3 dir;
    void Start()
    {
	target = Entro2ways.points[0];	
    }
    private void Update()
    {
        if (EveMouvement.eveMouvement == true)
        {
            dir = target.position - transform.position;
            transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);
            if(Vector3.Distance(transform.position, target.position) <= 0.2)
            {
                GetNextWaypoint();
            } 
        }
      
    }
    private void GetNextWaypoint()
    {
        if(waypointIndex == Entro2ways.points.Length-1)
        {   
            
            waypointIndex = 0;
            speed = 0f;
                dir = target.position - transform.position;
                transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);
            Debug.Log("Mission acomplie Drone2");
        }
        waypointIndex++;
        target = Entro2ways.points[waypointIndex];
    }
}
