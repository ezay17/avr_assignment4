using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBallColor : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void changeBallColor(Color color)
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Turn ball red"))
        {
            changeBallColor(Color.red);
        }

        if (GUILayout.Button("Turn ball yellow"))
        {
            changeBallColor(Color.yellow);
        }
    }   
}
