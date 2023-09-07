using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameData",order =1,fileName ="Game Config")]
public class GameInfo : ScriptableObject
{
    public  int[] GreenBallPoints = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
    public  int[] RedBallPoints = new int[] { -50, -100, -150 };

    public Constants.BallColor[] BallColor;
}
public class Constants
{
    public enum BallColor
    {
        Green,
        Red,
        Golden
    }

    public enum BallJump
    {
        Normal = 100,
        High
    }

    public enum BallPool
    {
        Green = 12,
        Red = 6,
        Golden = 1
    }

    public enum BallReservedPool
    {
        Green = 6,
        Red = 3,
        Golden = 1
    }

    public enum FeatureTrigger
    {
        None,
        Leader
    }
}

