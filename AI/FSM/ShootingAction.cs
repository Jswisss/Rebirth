//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PluggableAI/Actions/ShootAction")]
public class ShootingAction : Action
{
    public override void Act(AdversaryAITemplate adversary)
    {

        Fire(adversary);
        Debug.Log("Fire");

        if (!adversary.isDead)  
            Fire(adversary);

    }

    private void Fire(AdversaryAITemplate adversary)
    {
        Debug.DrawRay(adversary.eyes.position, adversary.eyes.forward.normalized * adversary.AttackRange, Color.red);
        if (Physics.SphereCast(adversary.eyes.position,adversary.ViewRadius,adversary.eyes.forward,out RaycastHit hit, adversary.AttackRange)
            && hit.collider.CompareTag("Player"))
        {
            if (adversary.CheckIfCountDownElapsed(adversary.AttackRate))
            {
                Debug.Log("Fire");
                adversary.Attack(adversary.AttackRate);
            }
        }
    }
}
