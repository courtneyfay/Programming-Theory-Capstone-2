using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : Animal
{
    [SerializeField] private Animator animator;

    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM - Fox class overrides virtual methods inherited from Animal class
    public override void Walk() 
    {
        animator.SetTrigger("walk");
    }
    public override void Jump()
    {
        animator.SetTrigger("jump");
    }
}
