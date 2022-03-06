//Evan
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiklusAnimationController : MonoBehaviour
{
    private Animator anim;
    private float x, y, z;
    private Vector3 direction;
    private Vector3 lastPosition;
    private Vector3 localDirection;
    public Transform player;
    public bool wait = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!wait)
            SelectAnimation();
    }

    void SelectAnimation()
    {
        direction = transform.position - lastPosition;
        localDirection = transform.InverseTransformDirection(direction);
        lastPosition = transform.position;

        if (Mathf.Abs(localDirection.z) > 0.01f)
        {
            anim.SetBool("Fly Forward", true);
        }
        else
            anim.SetBool("Fly Forward", false);
        if (Mathf.Abs(localDirection.z) < -0.01f)
        {
            anim.SetBool("Fly Backward", true);
        }
        else
            anim.SetBool("Fly Backward", false);
        if (Mathf.Abs(localDirection.x) > 0.01f)
        {
            anim.SetBool("Fly Right", true);
        }
        else
            anim.SetBool("Fly Right", false);
        if (Mathf.Abs(localDirection.z) < -0.01f)
        {
            anim.SetBool("Fly Left", true);
        }
        else
            anim.SetBool("Fly Left", false);
    }
}
