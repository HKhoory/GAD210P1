using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector2 pos;
   
    void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }
}
