﻿using UnityEngine;
using System.Collections;
public class  EveMouvement : MonoBehaviour
{
    public Rigidbody rb;


    void Start()
    {
        StartCoroutine(SomeWait());        
    }

    IEnumerator SomeWait() 
    {
        rb.AddForce(0,0,5000);
	    yield return new WaitForSeconds(5);
    }

    void Update()
    {
      
    }
}
