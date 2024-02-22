using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereForce : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, force);
    }
}
