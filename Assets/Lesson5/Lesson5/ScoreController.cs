using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void start()
    {
        score = 0;
        SetScore();
       
    }


    // Update is called once per frame
    void OnCollisionEnter( Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if(yourTag == "SmallStarTag")
        {
            score += 10;
            Debug.Log(score);
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 15;
            Debug.Log(score);
        }
        else if (yourTag == "SmallCloudTag")
        {
            score += 20;
            Debug.Log(score);
        }
        else if (yourTag == "LargeStarTag")
        {
            score += 25;
            Debug.Log(score);
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score );
    }
}
