using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkButtonController : MonoBehaviour
{
    RabbitController rabbitController;
    [SerializeField] private GameObject rabbit;
    FoxController foxController;
    [SerializeField] private GameObject fox;

    void Awake()
    {
        rabbitController = rabbit.GetComponent<RabbitController>();
        foxController = fox.GetComponent<FoxController>();
    }
    
    // ENCAPSULATION - private variable is exposed in the inspector with SerializeField label
    [SerializeField]
    private void ClickWalk()
    {
        foxController.Walk();
        rabbitController.Walk();
    }
}
