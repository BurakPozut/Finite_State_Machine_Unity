using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleWholeState : AppleBaseState
{
    float rottenCountDown = 5;
    public override void EnterState(AppleStateManager apple)
    {
        apple.rg.useGravity = true;
    }

    public override void UpdateState(AppleStateManager apple)
    {
        if(apple.appleMat.color.b > 0)
        {
            apple.appleMat.color -= new Color(.2f, .2f, .2f,0) * Time.deltaTime;
        }   
        else apple.SwitchState(apple.rottenState);
    }   

    public override void CollisionEnter(AppleStateManager apple, GameObject gameObject)
    {
        if(gameObject.GetComponent<PlayerController>())
        {
            gameObject.GetComponent<PlayerController>().playerMat.color = new Color(0, 255, 0, 255);   // Green
            apple.SwitchState(apple.chewedState);
        }
    }

}
