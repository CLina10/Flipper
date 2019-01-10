using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenResults : MonoBehaviour
{
    public GameObject panel;

    bool open;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            if (open == false)
            {
                open = true;
                Animator anim = panel.GetComponent<Animator>();
                anim.SetTrigger("openResults");
            }
        }
    }
}