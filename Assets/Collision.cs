using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public ChangeColor changeColor;
    public AudioSource audioSource;
    
    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        Debug.Log("Collision with " + other.gameObject.name);
        changeColor.changeBallColor(Color.red);
        audioSource.Play();
    }

    private void OnCollisionExit(UnityEngine.Collision other)
    {
        Debug.Log("Collision end with " + other.gameObject.name);
        changeColor.changeBallColor(Color.yellow);
    }
}
