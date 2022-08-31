using UnityEngine;

public class AppleRottenState : AppleBaseState
{

    public override void EnterState(AppleStateManager apple)
    {

    }

    public override void UpdateState(AppleStateManager apple)
    {

    }
    public override void CollisionEnter(AppleStateManager apple, GameObject gameObject)
    {
        if(gameObject.GetComponent<PlayerController>())
            gameObject.GetComponent<PlayerController>().playerMat.color = new Color(0, 0, 0, 255);   // Black
    }
}
