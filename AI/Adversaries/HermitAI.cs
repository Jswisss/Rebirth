using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HermitAI : AdversaryAITemplate
{
    public RobotHermitAnimationController RobotHermit;
    protected HermitAI()
    {
        ViewRadius = 200f;
        ViewRange = 15f;
        AttackRange = 5f;
        PatrolSpeed = 2.5f;
        ChaseSpeed = 5f;
        AttackRate = 1.25f;
    }

    public override void Attack(float attackRate)
    {
        //Attack animation currentlty isn't triggering
        if (Time.time > nextFireTime)
        {
            RobotHermit.wait = true;
            nextFireTime = Time.time + attackRate;
            Debug.Log("Attack");
            anim.ResetTrigger("Machine Gun Attack Front");
            //base.Attack(attackRate);
            //anim.ResetTrigger("BiteAttack");
            RobotHermit.wait = false;
        }
    }
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Move()
    {
        base.Move();
    }

    protected override void Target()
    {
        base.Target();
    }

    public override void Death()
    {
        if (!anim.GetBool("Die"))
        {
            anim.SetBool("Die", true);
            //attackSource.clip = atkClip;
            RobotHermit.enabled = false;
            base.Death();
        }
    }

    protected override void Update()
    {
        base.Update();
    }
}
