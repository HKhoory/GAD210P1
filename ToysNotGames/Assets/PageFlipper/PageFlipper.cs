using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFlipper : MonoBehaviour
{

    [SerializeField] private GameObject page;

    [SerializeField] private bool isFlipped;
    
    void Start()
    {
        isFlipped = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!isFlipped)
            {
                page.transform.localScale = Vector2.Lerp(transform.localScale, new Vector2(-1, transform.localScale.y), 1);
                isFlipped = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (isFlipped)
            {
                page.transform.localScale = Vector2.Lerp(transform.localScale, new Vector2(1, transform.localScale.y), 1);
                isFlipped = false;
            }
        }
    }
}
