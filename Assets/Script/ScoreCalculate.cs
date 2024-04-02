using UnityEngine;

public class ScoreCalculate : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
