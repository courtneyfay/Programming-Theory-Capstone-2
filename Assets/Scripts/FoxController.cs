using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : Animal
{
    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM - Fox class overrides virtual methods inherited from Animal class
    public override void Walk() 
    {
        // Player.Health -= 2;
        // CommitPettyTheft();
        Debug.Log("Fox is walking");
    }
    public override void Jump()
    {
        // make the animal jump
        Debug.Log("Fox is jumping");
        rb.AddForce(Vector3.up * 700f);
    }

    

    // private void Update()
    // {
    //     if (Player.isSeen)
    //     {
    //         DealDamage(); // method from parent class can be called
    //     }
    // }
}
