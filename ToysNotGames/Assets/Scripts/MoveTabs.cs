using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTabs : MonoBehaviour
{
    [SerializeField] public List<RectTransform> tabs = new List<RectTransform>();
    [SerializeField] public List<RectTransform> tabsClosed = new List<RectTransform>();

    public void MoveNext()
    {
        foreach (var item in tabs)
        {
            item.transform.position += Vector3.right * 157.5f;
        }
    }
}
