using UnityEngine;
public class DroneMouvement : MonoBehaviour
{

    // Déclaration de la variable de vitesse

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
	dir = target.position - transform.position;
	transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);
	if(Vector3.Distance(transform.position, target.position) <= 0.1){
		GetNextWaypoint();
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
	}
	
	waypointIndex++;
	target = Waypoints.points[waypointIndex];
    }
	


}
