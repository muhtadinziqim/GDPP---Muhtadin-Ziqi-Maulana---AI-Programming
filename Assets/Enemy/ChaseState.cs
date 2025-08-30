using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : BaseState
{
    public void EnterState(Enemy enemy)
    {
        Debug.Log("Start Chasing");
    }

    public void UpdateState(Enemy enemy)
    {
        Debug.Log("Chasing");
    }

    public void ExitState(Enemy enemy)
    {
        Debug.Log("Stop Chasing");
    }
}
