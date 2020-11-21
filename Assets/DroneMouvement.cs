using UnityEngine;
public class DroneMouvement : MonoBehaviour
{

    // Déclaration de la variable de vitesse

    public float speed = 1500f;
    private Transform target;
    private int waypointIndex = 0 ;
    void Start()
    {
	target = Waypoints.points[0];
	Debug.Log(target);	
    }
    private void Update()
    {
	Vector3 dir = target.position - transform.position;
	transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);
	if(Vector3.Distance(transform.position, target.position) <= 0.2){
		GetNextWaypoint();
        }
    }
    private void GetNextWaypoint()
    {
	if(waypointIndex >= Waypoints.points.Length-1)
	{
		waypointIndex=0;
		target = Waypoints.points[0];
	}
	waypointIndex++;
	target = Waypoints.points[waypointIndex];
    }
	


}
