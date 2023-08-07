using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyStrikeState : EnemyBaseState
{
    float waitToPatrol = 10f;

    public override void EnterState(EnemyStateManager Enemy)
    {

    }

    public override void OnTriggerEnter(EnemyStateManager Enemy, Collider Other)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(EnemyStateManager Enemy)
    {
        waitToPatrol -= Time.deltaTime;

        if (waitToPatrol <= 0)
        {
            
            Enemy.SwitchState(Enemy.chasingState);
        }
        else
        {
            Enemy.CharatereAnimator.Play("Golpe");

        }
    }

    
}