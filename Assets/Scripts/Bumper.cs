using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float force = 150;
    public int scoreValue;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            float x = collision.rigidbody.velocity.x > 0 ? force : -force;
            float z = collision.rigidbody.velocity.z > 0 ? force : -force;
            collision.rigidbody.AddForce(new Vector3(x, 0f, z));

            Score.score += scoreValue;
        }
    }
}