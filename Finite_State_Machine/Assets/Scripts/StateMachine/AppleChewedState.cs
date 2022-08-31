using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleChewedState : AppleBaseState
{

    public override void EnterState(AppleStateManager apple)
    {
        Debug.Log("I have been eaten");
    }

    public override void UpdateState(AppleStateManager apple)
    {

    }
    public override void CollisionEnter(AppleStateManager apple, GameObject gameObject)
    {
        // Here we can start a count down to destroy the apple
    }
}
