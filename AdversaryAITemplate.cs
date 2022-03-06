//Ronald Ison
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// Going to merge StateController into this class
/// </summary>
public abstract class AdversaryAITemplate : MonoBehaviour, IDamagable
{
    #region variables
    public AudioSource attackSource, movementSource;
    public AudioClip dmgClip, atkClip, walkClip, runClip;
    public Transform eyes;
    public State currentState, remainState;
    protected Animator anim;
    protected float health, healthMax;
    protected float speed, speedMax;
    protected float nextFireTime;
    public bool isDead = false;
    protected Vector3 originalPos { get; private set; }
    private Rigidbody rb;
    private bool aiActive;

    public List<Transform> wayPointList;
    [HideInInspector] public int nextWayPoint;
    [HideInInspector] public Transform chaseTarget;
    [HideInInspector] private float stateTimeElapsed = 0;
    #endregion

    protected virtual void Awake()
    {
        Nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    protected virtual void Update()
    {
        currentState.UpdateState(this);
    }

    void IDamagable.TakeDamage(float damage)
    {

    }

    protected virtual void Move()
    {

    }

    protected virtual void Target()
    {

    }
    
    public virtual void Death()
    {
        isDead = true;
        if (!Nav.isStopped)
            Nav.isStopped = true;
        Nav.enabled = false;
        anim.SetTrigger("Die");
    }

    public virtual void Attack(float attackRate)
    {

    }

    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
            OnExitState();
        }
    }

    public bool CheckIfCountDownElapsed(float duration)
    {
        StateTimeElapsed += Time.deltaTime;
        return (StateTimeElapsed >= duration);
    }

    private void OnExitState()
    {
        StateTimeElapsed = 0;
    }

    private void OnDrawGizmos()
    {
        if (currentState != null && eyes != null)
        {
            Gizmos.color = currentState.sceneGizmoColor;
            Gizmos.DrawWireSphere(eyes.position, ViewRadius);
        }
    }

    public float PatrolSpeed { get; protected set; }
    public float ChaseSpeed { get; protected set; }
    public float AttackRange { get; protected set; }
    public float AttackRate { get; protected set; }
    public float ViewRange{ get; protected set; }
    public float ViewRadius { get; protected set; }
    public float StateTimeElapsed { get => stateTimeElapsed; set => stateTimeElapsed = value; }
    public NavMeshAgent Nav { get; protected set; }
}
