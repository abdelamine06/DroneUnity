using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0,0,600); 
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey("d"))
        {
            rb.AddForce(50,0,0);
        }

        if (Input.GetKey("g"))
        {
             rb.AddForce(-50,0,0);
        }
    }
}
