using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    Vector3 Pos;
    private void Start()
    {
        Pos = new Vector3();
        Pos.z = -10;
    }
    private void FixedUpdate()
    {
        Pos.x = Mathf.Lerp(-0.5f, 0.5f, Input.mousePosition.x / Screen.width);
        Pos.y = Mathf.Lerp(-0.3f, 0.3f, Input.mousePosition.y / Screen.height);
        transform.position = Pos;
    }
}
