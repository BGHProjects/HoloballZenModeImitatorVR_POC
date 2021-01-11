 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isHit = false;

    private Rigidbody r;
        
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isHit && r.velocity.magnitude < 1.5f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter()
    {
        isHit = true;
    }
}
