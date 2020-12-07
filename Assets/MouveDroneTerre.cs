using UnityEngine;
public class MouveDroneTerre : MonoBehaviour
{
    public float speed = 15f;
    private Transform target;
    private int waypointIndex = 0 ;
    private Vector3 dir;
    void Start()
    {
	target = WaypointsDroneTerre.points[0];	
    }

    private void Update()
    {
      if(DroneMouvement.PortailOpen == true)
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
        if(waypointIndex == Waypoints.points.Length)
        {
          
            waypointIndex = 0;
            speed = 0f;
	    MouvePortail.DroneTclose = true;
            dir = target.position - transform.position;
                transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);	
           

        }
	
        waypointIndex++;
	
        target = WaypointsDroneTerre.points[waypointIndex];
    }
	

   
	


}
