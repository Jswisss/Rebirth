//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SicklusAI : AdversaryAITemplate
{
    public SiklusAnimationController siklus;
    
    protected SicklusAI()
    {
        ViewRadius = 2f;
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
            siklus.wait = true;
            nextFireTime = Time.time + attackRate;
            Debug.Log("Attack");
            anim.ResetTrigger("BiteAttack");
            //base.Attack(attackRate);
            //anim.ResetTrigger("BiteAttack");
            siklus.wait = false;
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
//            attackSource.clip = atkClip;
            siklus.enabled = false;
            base.Death();
        }
    }

    protected override void Update()
    {
        base.Update();
    }
}
