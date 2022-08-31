using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleStateManager : MonoBehaviour
{
    public AppleBaseState currentState;
    public AppleGrowingState growingState = new AppleGrowingState();
    public AppleChewedState chewedState = new AppleChewedState();
    public AppleRottenState rottenState = new AppleRottenState();
    public AppleWholeState wholeState = new AppleWholeState();

    [HideInInspector] public Rigidbody rg;
    public Material appleMat;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        currentState = growingState;

        currentState.EnterState(this);

    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(AppleBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    private void OnCollisionEnter(Collision other) 
    {
        currentState.CollisionEnter(this, other.gameObject);
    }
}
