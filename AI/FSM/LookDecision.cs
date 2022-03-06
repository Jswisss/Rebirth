//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Look")]
public class LookDecision : Decision
{
    public override bool Decide(AdversaryAITemplate adversary)
    {
        bool targetVisible = Look(adversary);
        return targetVisible;
    }

    private bool Look(AdversaryAITemplate adversary)
    {
        RaycastHit hit;

        Debug.DrawRay(adversary.eyes.position, adversary.eyes.forward.normalized * adversary.ViewRange, Color.blue);
        if(Physics.SphereCast(adversary.eyes.position,adversary.ViewRadius,adversary.eyes.forward, out hit, adversary.ViewRange)
            && hit.collider.CompareTag("Player"))
        {
            adversary.chaseTarget = hit.transform;
            return true;
        }
        else
        {
            return false;
        }
    }
}
