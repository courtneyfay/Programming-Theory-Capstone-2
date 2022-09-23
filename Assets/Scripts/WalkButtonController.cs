using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkButtonController : MonoBehaviour
{
    // ENCAPSULATION - private variable is exposed in the inspector with SerializeField label
    [SerializeField]
    private void ClickWalk()
    {
        Debug.Log("hitting walk button controller");
        // fox.Walk();
        // rabbit.Walk();
    }
}
