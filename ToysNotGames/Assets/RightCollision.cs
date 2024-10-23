using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollision : MonoBehaviour
{
    public bool isCollided;
    public static int numberOfCollided;
    // Start is called before the first frame update
    void Start()
    {
        isCollided = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Finger"&& Input.GetMouseButton(0))
        {
            if(!isCollided)
            {
                numberOfCollided++;
                //Debug.Log(numberOfCollided);
                isCollided = true;
            }
            StartCoroutine(StartTimer());
        }
    }
    private IEnumerator StartTimer()
    {
        // Wait for 6 seconds
        yield return new WaitForSeconds(5f);

        numberOfCollided--;
        //Debug.Log(numberOfCollided);
    }
   
    
}
