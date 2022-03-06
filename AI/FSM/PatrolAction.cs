//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PluggableAI/Actions/Patrol")]
public class PatrolAction : Action
{
    public override void Act(AdversaryAITemplate adversary)
    {
        if(!adversary.isDead)
            Patrol(adversary);
    }

    private void Patrol(AdversaryAITemplate adversary)
    {
        adversary.Nav.speed = adversary.PatrolSpeed;
        adversary.Nav.SetDestination(adversary.wayPointList[adversary.nextWayPoint].position);
        if(adversary.Nav.isStopped)
            adversary.Nav.isStopped = false;
        if (adversary.Nav.remainingDistance <= adversary.Nav.stoppingDistance && !adversary.Nav.pathPending)
        {
            adversary.nextWayPoint = (adversary.nextWayPoint + 1) % adversary.wayPointList.Count;
        }
    }
}
