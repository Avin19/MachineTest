using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    // maintain 10 balls
   
    [SerializeField] private GameObject parentBall;

    [SerializeField] private List<Transform> ballTransfroms = new List<Transform>();
    

    private void Start()
    {
        for( int i = 0; i<11; i++)
        {
            int ran = Random.Range(0, 18);
            ballTransfroms.Add(parentBall.transform.GetChild(ran));
           
            
        }
        foreach( Transform t in ballTransfroms )
        {
            t.gameObject.SetActive(true);
            
            t.position = new Vector3(ran, t.position.y, t.position.z);
          
          
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        
    }




}
