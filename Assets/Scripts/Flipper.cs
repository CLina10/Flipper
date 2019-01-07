using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float restPos = 0f;
    public float activePos = 45f;
    public float strenght = 10000f;
    public float flipperDamper = 150f;

    public string inputName;

    HingeJoint hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }

    void Update()
    {
        JointSpring jSpring = new JointSpring();
        jSpring.spring = strenght;
        jSpring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            jSpring.targetPosition = activePos;
        }
        else
        {
            jSpring.targetPosition = restPos;
        }
        hinge.spring = jSpring;
        hinge.useLimits = true;
    }
}