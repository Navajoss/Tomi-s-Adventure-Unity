using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{   
    EnemyBaseState currentState;
    
    public EnemyChasingState chasingState = new EnemyChasingState();
    public EnemyStrikeState strikeState = new EnemyStrikeState();
    public Animator CharatereAnimator;
    public Transform player;
    public Transform[] waypoints;

    public void Start()
    {
        currentState = chasingState;

        currentState.EnterState(this);
    }

    public void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public void OnTriggerEnter(Collider Other)
    {
        currentState.OnTriggerEnter(this, Other);
    }
}