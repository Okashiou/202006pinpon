using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{

    private float visibleProZ = -6.5f;

    private GameObject gameoverText;

    private GameObject socreText;



    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreLabel");

    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visibleProZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
            
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameobject.name == “LargeStar”)
        {
            AddScore();
        }
  
    }


    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "SCORE：" + score;
    }


}
