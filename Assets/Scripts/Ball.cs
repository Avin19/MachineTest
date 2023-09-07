using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.PlayerSettings;


public class Ball : MonoBehaviour
{
    Rigidbody mRigidBody;
    int BallPoints;

    public GameObject BallObj;

    public Constants.BallColor eBallType;
    [SerializeField]
    TextMeshPro ScoreText;

    bool mGoldenFeaturedBall=false;
     int mIndex;

    public int Index { get => mIndex; set => mIndex = value; }
    public int BallPoints1 { get => BallPoints; set => BallPoints = value; }

    public void SetColorPooledBall(int index)
    {
        Material mat = BallObj.GetComponent<MeshRenderer>().material;

        if (index < (int)Constants.BallPool.Green)
        {
            mat.color = Color.green;
            eBallType = Constants.BallColor.Green;
            this.gameObject.name= Constants.BallColor.Green.ToString();
        }
        else if (index < (int)Constants.BallPool.Red + (int)Constants.BallPool.Green)
        {
            mat.color = Color.red;
            eBallType = Constants.BallColor.Red;
            this.gameObject.name = Constants.BallColor.Red.ToString();
        }
        else
        {
            mat.color = Color.yellow;
            eBallType = Constants.BallColor.Golden;
            this.gameObject.name = Constants.BallColor.Golden.ToString();
        }

    }

    /// <summary>
    /// Used to set the random score from the given set of array 
    /// </summary>
    public void SetRandomPoint()
    {
        int ran = Random.Range(-12, 12);
    }
 

   
}
