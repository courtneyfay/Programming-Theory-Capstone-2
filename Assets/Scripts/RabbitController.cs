using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitController : Animal
{
    [SerializeField] private Animator animator;

    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM - Rabbit class overrides virtual methods inherited from Animal class
    public override void Walk() 
    {
        animator.SetTrigger("run");
    }
    public override void Jump()
    {
        rb.AddForce(Vector3.up * 300f);
    }
}
