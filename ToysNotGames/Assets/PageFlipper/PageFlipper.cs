using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFlipper : MonoBehaviour
{

    [SerializeField] private GameObject page;
    [SerializeField] private GameObject[] pages;

    [SerializeField] private bool isFlipped;

    [SerializeField] private int pageCount;
    [SerializeField] private int maxPageCount;
    

    public struct PageInfo
    {
        public bool isFlipped1;
        public int pageCount1;
    }

    public class PagesInfo
    {

    }

    void Start()
    {

        maxPageCount = pages.Length;
        isFlipped = false;
        pageCount = 0;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!isFlipped)
            {
                pages[pageCount].transform.localScale = Vector2.Lerp(transform.localScale, new Vector2(-1, 1), 1);
                isFlipped = true;
                pageCount++;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (isFlipped)
            {
                pages[pageCount].transform.localScale = Vector2.Lerp(transform.localScale, new Vector2(1, 1), 1);
                isFlipped = false;
                pageCount--;
            }
        }
    }
}
