using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitController : Animal
{
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM - Rabbit class overrides virtual methods inherited from Animal class
    public override void Walk() 
    {
        // Player.Health -= 2;
        // CommitPettyTheft();
        Debug.Log("Rabbit is walking");
    }
    public override void Jump()
    {
        rb.AddForce(Vector3.up * 300f);
    }
}
