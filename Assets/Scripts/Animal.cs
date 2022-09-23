using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE - Animal is the parent class that the Rabbit and Fox child classes inherit from
public class Animal : MonoBehaviour
{
    // POLYMORPHISM - virtual keyword allows overriding 
    public virtual void Walk()
    {
        // make the animal walk
        Debug.Log("Animal is walking");
    }

    // ABSTRACTION - functions abstract out complicated logic
    public virtual void Jump()
    {
        // make the animal jump
        Debug.Log("Animal is jumping");
    }
}
