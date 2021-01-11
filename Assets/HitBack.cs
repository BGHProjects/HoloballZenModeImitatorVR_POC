using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class HitBack : MonoBehaviour
{
    public Transform head;

    void OnCollisionEnter()
    {
        Rigidbody r = BallManager.Instance.CurrentBall.GetComponent<Rigidbody>();

        r.angularVelocity = Vector3.zero;
        Vector3 dir = (head.position - r.transform.position).normalized;
        r.velocity = dir * 5f;
    }
}
