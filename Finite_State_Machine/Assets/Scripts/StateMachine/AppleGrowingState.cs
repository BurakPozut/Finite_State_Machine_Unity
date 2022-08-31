using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGrowingState : AppleBaseState
{
    Vector3 growScale = new Vector3(2, 2, 2);
    public override void EnterState(AppleStateManager apple)
    {
        
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if(apple.transform.localScale.x < 30)   apple.transform.localScale += growScale * Time.deltaTime;
        else apple.SwitchState(apple.wholeState);

    }
    public override void CollisionEnter(AppleStateManager apple, GameObject gameObject)
    {
        
    }
}
