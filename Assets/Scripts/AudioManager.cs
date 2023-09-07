using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
     private AudioSource audioSource;



     [SerializeField] private AudioClip[] audioClips;

     private void Awake()
     {
       
        audioSource = GetComponent<AudioSource>();
        BallController.Instance.OnBounce += BallController_OnBounce;


     }

     private void BallController_OnBounce(object sender, EventArgs e)
     {
        audioSource.PlayOneShot(audioClips[0]);
     }
    


   
}
