using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public void changeBallColor(Color color)
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
