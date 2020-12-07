using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouveDroneTerre : MonoBehaviour
{
	public Rigidbody MouveDroneTerre;


    void Start()
    {
         rigid.AddForce(0,1200,5000);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
