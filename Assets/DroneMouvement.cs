using UnityEngine;
public class DroneMouvement : MonoBehaviour
{
    public float speed = 1500f;
    private Transform target;
    private int waypointIndex = 0 ;
    private Vector3 dir;
    void Start()
    {
	    target = Waypoints.points[0];	
    }

    private void Update()
    {
        if (SensorBehavior.detectedMotion == true)
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
        if(waypointIndex == Waypoints.points.Length-1)
        {
          
            waypointIndex = 0;
            speed = 0f;
            dir = target.position - transform.position;
                transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);	
            Debug.Log("Mission acomplie Drone1");
  	    ScreenShoot.camera.enabled = true;

        }
	
        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }
	


}
