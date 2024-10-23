using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
   public AudioSource audioSource;
   public float minPitch = -3f;
    public float maxPitch = 3f;
    private Vector3 lastMousePosition;
    private bool isPlaying;


    void Start() 
    {
        isPlaying = false;
    }
   
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePosition = Input.mousePosition;
            float mouseSpeed = (currentMousePosition - lastMousePosition).magnitude / Time.deltaTime;

            if (mouseSpeed > 0.15f) 
            {
                if (!isPlaying)
                {
                    
                    audioSource.Play();
                    isPlaying = true;
                }
                float newPitch = Mathf.Lerp(-3, 3, mouseSpeed / 10000.0f);
                audioSource.pitch = newPitch;
                //Debug.Log("Mouse speed " + mouseSpeed/10000);
                //Debug.Log("New pitch is " + newPitch);
            }
            else
            {
                if (isPlaying)
                {
                    audioSource.Stop();
                    isPlaying = false;
                }
            }

        lastMousePosition = currentMousePosition;   
        }

        if (Input.GetMouseButtonUp(0))
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }

    
}
