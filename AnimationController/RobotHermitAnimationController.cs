using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHermitAnimationController : MonoBehaviour
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
        if (!wait)
            SelectAnimation();
    }

    void SelectAnimation()
    {
        direction = transform.position - lastPosition;
        localDirection = transform.InverseTransformDirection(direction);
        lastPosition = transform.position;

        if (Mathf.Abs(localDirection.z) > 0.01f)
        {
            anim.SetBool("Walk Forward WO Root", true);
        }
        else
            anim.SetBool("Walk Forward WO Root", false);

        if (Mathf.Abs(localDirection.z) < -0.01f)
        {
            anim.SetBool("Walk Backward WO Root", true);
        }
        else
            anim.SetBool("Walk Backward WO Root", false);

        if (Mathf.Abs(localDirection.x) > 0.01f)
        {
            anim.SetBool("Walk Right WO Root", true);
        }
        else
            anim.SetBool("Walk Right WO Root", false);

        if (Mathf.Abs(localDirection.z) < -0.01f)
        {
            anim.SetBool("Walk Left WO Root", true);
        }
        else
            anim.SetBool("Walk Left WO Root", false);
    }
}
