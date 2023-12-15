using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;

    int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = Score.ToString() + " points";
    }

    // Update is called once per frame
    public void addpoints() 
    {
        Score += 1;
        scoretext.text = Score.ToString() + "points";
    }
}
