using UnityEngine;

public abstract class EnemyBaseState
{
    public abstract void EnterState(EnemyStateManager Enemy);

    public abstract void UpdateState(EnemyStateManager Enemy);

    public abstract void OnTriggerEnter(EnemyStateManager Enemy, Collider Other);
}