using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPhysicsPosition : MonoBehaviour
{

    private Rigidbody r;

    public SteamVR_TrackedObject controller;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        r.MovePosition(controller.transform.position);
        r.MoveRotation(controller.transform.rotation);
    }
}
