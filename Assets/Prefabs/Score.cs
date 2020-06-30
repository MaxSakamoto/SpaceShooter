using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int ScoreValue;



    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score=" + ScoreValue;
    }

    public void addPoints(int Points)
    {
        ScoreValue += Points;
        ScoreText.text = "Score=" + ScoreValue;
    }

    // Update is called once per frame
    public void ReducePoints(int Points)
    {
        ScoreValue -= Points;
        ScoreText.text = "Score=" + ScoreValue;
    }
}
