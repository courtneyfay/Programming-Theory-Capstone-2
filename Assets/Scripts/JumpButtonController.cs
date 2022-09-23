using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButtonController : MonoBehaviour
{
    // ENCAPSULATION - private variable is exposed in the inspector with SerializeField label
    [SerializeField]
    private void ClickJump()
    {
        Debug.Log("hitting JUMP button controller");
        // fox.Jump();
        // rabbit.Jump();
    }
}