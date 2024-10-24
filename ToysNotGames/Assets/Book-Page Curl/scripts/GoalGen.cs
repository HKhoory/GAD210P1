using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GoalGen : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI goalText;
    [SerializeField] private bool pageTrue;
    [SerializeField] private int targetPage;


    void Start()
    {
        pageTrue = false;
        targetPage = Random.Range(1, 7);
        goalText.text = "Turn to page" + targetPage;
    }


    void Update()
    {
        if (pageTrue)
        {
            targetPage = Random.Range(0, 7);
            goalText.text = "Good, now turn to page " + targetPage;
            pageTrue = false;
        }

        if (targetPage == Book.currentPage)
        {
            pageTrue = true;
        }
        else if (targetPage == (Book.currentPage - 1))
        {
            pageTrue = true; //&=
        }
    }
}
