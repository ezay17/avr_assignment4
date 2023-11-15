using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float force = 10.0f;
    public Vector3 launchDirection = Vector3.right;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void ShootBall()
    {
        _rigidbody.AddForce(force * launchDirection, ForceMode.Impulse);
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Shoot"))
        {
            ShootBall();
        }
    }
}
