//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDummyAI : AdversaryAITemplate
{
    protected TestDummyAI()
    {

        ViewRadius = 10f;
        ViewRange = 20f;
        PatrolSpeed = 3.5f;
        ChaseSpeed = 5f;

        ViewRadius = 15f;
        ViewRange = 5f;
        AttackRange = 5f;
        PatrolSpeed = 3.5f;
        ChaseSpeed = 5f;
        AttackRate = 1.25f;
    }

    public override void Attack(float attackRate)
    {
        Debug.Log("Attack");
        anim.SetTrigger("BiteAttack");
        base.Attack(attackRate);
        anim.ResetTrigger("BiteAttack");
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
        base.Death();
    }

    protected override void Update()
    {
        base.Update();
    }
}
