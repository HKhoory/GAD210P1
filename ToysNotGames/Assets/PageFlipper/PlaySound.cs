using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    [SerializeField] private AudioSource pageFlip;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        pageFlip.Play();
    }
}
