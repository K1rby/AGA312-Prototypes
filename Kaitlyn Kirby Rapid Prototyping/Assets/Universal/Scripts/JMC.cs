using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JMC : MonoBehaviour
{
    [HideInInspector]
    public float globalTweenTime = 0.5f;

    /// <summary>
    /// Check if we're at Game Over
    /// </summary>
    /// <param name="lives">Player's current lives. When at 0, will return to true</param>
    /// <returns></returns>

    public bool IsGameOver(int lives)
    {
        return lives == 0;
    }

    /// <summary>
    /// Works out the change in percentage between two scores
    /// </summary>
    /// <param name="scoreOne">The first score</param>
    /// /// <param name="scoreTwo">The second score</param>
    /// <returns></returns>
    /// 
    public static float PercentageChange(float scoreOne, float scoreTwo)
    {
        float change = scoreTwo - scoreOne;
        return change / scoreOne * 100;
    }
}
