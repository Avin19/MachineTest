using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float Speed = 10;
 
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left  * Speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * Speed);
        }
    }

    /// <summary>
    /// Used to check the collision from the moving balls
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Ball") ) 
        {
         
        }
    }
}
