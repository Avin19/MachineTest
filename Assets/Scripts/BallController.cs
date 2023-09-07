using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallController : MonoBehaviour
{
    public event EventHandler OnBounce;
    public event EventHandler OnCrash;
    [SerializeField] private Rigidbody rb;

    public static BallController Instance { get; private set; }

    private void Awake()
    {
        if(Instance !=null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            
            OnBounce?.Invoke(this, EventArgs.Empty);
            rb.velocity = Vector3.up * 6f;
        }
        if(collision.gameObject.tag == "Player")
        {
            OnCrash?.Invoke(this, EventArgs.Empty);
        }
    }
}
