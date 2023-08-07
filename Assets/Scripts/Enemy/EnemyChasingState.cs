using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasingState : EnemyBaseState
{
    bool inRangeOfPlayer;
    float speed = 0.5f;
    float minimunDistance = 0.4f;
    int hit = 0;
    float hitCooldown = 2f;
    

    public override void EnterState(EnemyStateManager Enemy)
    {
        inRangeOfPlayer = true;
    }

    public override void UpdateState(EnemyStateManager Enemy)
    {
        hitCooldown -= Time.deltaTime;
        
        if(Vector3.Distance(Enemy.transform.position, Enemy.player.position) <= minimunDistance)
        {
            
            inRangeOfPlayer = false;
        }
        
        if (inRangeOfPlayer == false)
        {
            Enemy.SwitchState(Enemy.strikeState);
        }
        else
        {
            Enemy.transform.LookAt(Enemy.player.position);
            Enemy.CharatereAnimator.Play("Walk");
            Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Enemy.player.position, speed * Time.deltaTime);
        }
    }

    public override void OnTriggerEnter(EnemyStateManager Enemy, Collider Other)
    {

    }
}