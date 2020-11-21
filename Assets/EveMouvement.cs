using UnityEngine;
using System.Collections;
public class EveMouvement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
	StartCoroutine(MyMethod());
	
        
    }
    IEnumerator MyMethod() {
	yield return new WaitForSeconds(5);
	rb.AddForce(0,0,800); 
    }
    // Update is called once per frame
    void Update()
    {
     
        
    }
}
