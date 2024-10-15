using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragPanel : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] public Vector2 startPoint;
    [SerializeField] private Vector2 endPoint;
    [SerializeField] private float yThreshold = 320f;

    [SerializeField] RectTransform nextPanel;
    [SerializeField] MoveTabs moveTabs;
    

    public void ResetPosition(BaseEventData eventData)
    {
        if (transform.position.y >= yThreshold)
        {
            moveTabs.tabsClosed.Add(gameObject.GetComponent<RectTransform>());
            moveTabs.tabs.Remove(gameObject.GetComponent<RectTransform>());
            gameObject.SetActive(false);
            moveTabs.MoveNext();
        }
        else
        {
            transform.position = canvas.transform.TransformPoint(startPoint);
        }
    }

    public void DragHandler(BaseEventData eventData)
    {
        PointerEventData pointerEventData = eventData as PointerEventData;
        var rect = gameObject.GetComponent<RectTransform>();
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform, 
            pointerEventData.position, 
            canvas.worldCamera, 
            out position
            );
        transform.position = canvas.transform.TransformPoint(new Vector2(rect.position.x, position.y));
    }
}
