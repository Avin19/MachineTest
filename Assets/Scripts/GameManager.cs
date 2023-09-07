using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;
using static UnityEditor.PlayerSettings;
using Unity.VisualScripting;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    GameInfo GameInfo;

    [SerializeField]
    GameObject[] BallAnimation;

    [SerializeField]
    GameObject BallPrefab;

    [SerializeField]
    Transform ParentBalls;

    [SerializeField]
    TextMeshProUGUI ScoreText;
    public int Score;

    public List<Ball> BallsList = new List<Ball>();

    public GameInfo GAME_INFO { get => GameInfo; set => GameInfo = value; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
             BallInit();
    }

    private void Start()
    {
        
    }
    /// <summary>
    /// Init the ball at the beginning of game
    /// </summary>
    public void BallInit()
    {
        int count = (int)Constants.BallPool.Green + (int)Constants.BallPool.Red + (int)Constants.BallPool.Golden;
        for (int i = 0; i < count; i++)
        {
            GameObject go = Instantiate(BallPrefab);
            go.transform.SetParent(ParentBalls); 
            Ball ball= go.GetComponent<Ball>();
            ball.SetColorPooledBall(i);
            ball.SetRandomPoint();
            BallsList.Add(ball);
            ball.BallObj.gameObject.SetActive(false);
        }

    }
   
}
