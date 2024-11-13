using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WikiGoal : MonoBehaviour
{
    public int PageID = 0;
    [SerializeField] private List<string> PageNames = new List<string>();
    [SerializeField] private int pageGoal;

    [SerializeField] private TMP_Text insturction;
    // Start is called before the first frame update
    void Start()
    {
        NewGoal();
    }

    // Update is called once per frame
    void Update()
    {
        if (PageID == pageGoal)
        {
            NewGoal();
        }
    }

    public void SetID(int id) { PageID = id; }

    public void NewGoal()
    {
        // Chose somewhere else to go
        int newID = 0;
        do
        {
            newID = Random.Range(0, PageNames.Count);
        } while (newID == pageGoal);
        pageGoal = newID;
        
        insturction.text = $"Go to the {PageNames[pageGoal]} wiki!"; // Say where to go now
    }
}
