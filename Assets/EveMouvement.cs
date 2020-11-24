using UnityEngine;
using System.Collections;
public class  EveMouvement : MonoBehaviour
{
    public Rigidbody rb;
    public static bool eveMouvement = false;

    void Start()
    {
        StartCoroutine(MyMethod());        
    }

    IEnumerator MyMethod() 
    {
        rb.AddForce(0,0,800);
	    yield return new WaitForSeconds(5);
        eveMouvement = true;
    }

    void Update()
    {
      
    }
}
