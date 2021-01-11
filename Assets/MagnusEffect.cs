using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody r;

    public float magnusConst = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 force = magnusConst * Vector3.Cross(r.velocity, r.angularVelocity);
        r.AddRelativeForce(force);
    }
}
