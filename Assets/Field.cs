using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public Vector3 direction;
    public float force;

    private Rigidbody _rigidbody;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        _rigidbody = other.gameObject.GetComponent<Rigidbody>();
        _rigidbody.AddForce(direction * force, ForceMode.Impulse);
    }
}
