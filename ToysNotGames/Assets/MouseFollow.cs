using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    Vector2 pos;
    TrailRenderer trailRenderer;
    GameObject currentTrail;
    public GameObject prefab;
   
    void Start()
    {
        Cursor.visible = false;
        trailRenderer = GetComponent<TrailRenderer>();
        trailRenderer.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;

         if (Input.GetMouseButtonDown(0))
        {
            trailRenderer.enabled = true;
            trailRenderer.emitting = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            trailRenderer.emitting = false;
        }
    }

}
