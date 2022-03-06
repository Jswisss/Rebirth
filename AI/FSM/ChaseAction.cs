//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{
    public override void Act(AdversaryAITemplate adversary)
    {
        if(!adversary.isDead)
            Chase(adversary);
    }

    private void Chase(AdversaryAITemplate adversary)
    {
        adversary.Nav.speed = adversary.ChaseSpeed;
        adversary.Nav.destination = adversary.chaseTarget.position;
        if (adversary.Nav.isStopped)
            adversary.Nav.isStopped = false;
    }
}
