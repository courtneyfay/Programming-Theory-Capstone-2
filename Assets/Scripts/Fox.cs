using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Animal
{
    // POLYMORPHISM - Fox class overrides virtual methods inherited from Animal class
    public override void Walk() 
    {
        // Player.Health -= 2;
        // CommitPettyTheft();
    }
    public override void Jump()
    {
        // make the animal jump
    }

    // private void Update()
    // {
    //     if (Player.isSeen)
    //     {
    //         DealDamage(); // method from parent class can be called
    //     }
    // }
}
