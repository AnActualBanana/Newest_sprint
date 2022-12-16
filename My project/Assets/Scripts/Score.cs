using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Player Player;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
            {
            scoreText.text = "Score:" + Player.score.ToString("0") + "\n" + "Lives:";
            }
    }
}
