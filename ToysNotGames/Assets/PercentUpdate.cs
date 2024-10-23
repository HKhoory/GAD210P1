using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PercentUpdate : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    int childCount;
    // Start is called before the first frame update
    void Start()
    {
        GameObject parentObject = GameObject.Find("CircleDrawings");
        childCount = parentObject.transform.childCount;
        
    }

    // Update is called once per frame
    void Update()
    {
        float ratio = (float) RightCollision.numberOfCollided / (float) childCount;
        Debug.Log(RightCollision.numberOfCollided);
        float percentage = ratio * 100;
        textMeshPro.text = "You have drawn " + percentage + "% of it";
    }
}
