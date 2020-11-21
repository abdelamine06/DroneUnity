using UnityEngine;
public class Drone1Mouvement : MonoBehaviour
{

    // Déclaration de la variable de vitesse

    public float speed = 1500f;
    private Transform target;
    private int waypointIndex = 0 ;
    private Vector3 dir;
    void Start()
    {
	target = Entro2ways.points[0];
	Debug.Log(target);	
    }
    private void Update()
    {
	dir = target.position - transform.position;
	transform.Translate(dir.normalized* speed * Time.deltaTime, Space.World);
	if(Vector3.Distance(transform.position, target.position) <= 0.2){
		GetNextWaypoint();
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
