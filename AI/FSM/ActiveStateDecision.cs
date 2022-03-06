//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PluggableAI/Decisions/ActiveState")]
public class ActiveStateDecision : Decision
{
    public override bool Decide(AdversaryAITemplate adversary)
    {
        bool chaseTargetisActive = adversary.chaseTarget.gameObject.activeSelf;
        return chaseTargetisActive;
    }

}
