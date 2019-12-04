using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetScore(4, "Franzl Schneider");
    }

    // Update is called once per frame
    void Update()
    {
        SetScore(5, "Bruno Hauser");
    }
    public void SetScore(int score, string name)
    {
        int scoreValue = score;
        string nameValue = name;
        Debug.Log("Score = " + scoreValue + " Name = " + nameValue);
    }
}

