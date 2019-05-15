using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desv2MUp : MonoBehaviour
{
    private GameObject canvas;

    private void OnTriggerEnter(Collider other)
    {
        canvas = GameObject.Find("CanvasDesv");
        if (canvas != null)
        {
            canvas.SendMessage("d2mup");
        }
    }

}

