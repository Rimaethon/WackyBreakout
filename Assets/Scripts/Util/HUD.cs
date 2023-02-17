using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    #region Fields
    [SerializeField] GameObject ballsLeftTextGameObject;
    [SerializeField] GameObject scoreTextGameObject;
    //balls left text
    const string ballsLeftPrefix = "Balls Left: ";
    public static int ballsLeft = 0;
    static Text ballsLeftText;

    //score text 
    const string scorePrefix = "Score: ";
    static int score = 0;
    static Text scoreText;




    #endregion
    // Start is called before the first frame update
    #region Unity Methods
    void Start()
    {
        ballsLeft = ConfigurationUtils.BallsPerGame;
        ballsLeftText = ballsLeftTextGameObject.GetComponent<Text>();
        ballsLeftText.text = ballsLeftPrefix + ballsLeft.ToString();

        score = 0;
        scoreText = scoreTextGameObject.GetComponent<Text>();
        scoreText.text = scorePrefix + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    #region Public Methods

    public static void LoseBall()
    {
        ballsLeft--;
        ballsLeftText.text = ballsLeftPrefix + ballsLeft.ToString();

    }
    public static void AddPoints(int points)
    {
        score += points;
        scoreText.text = scorePrefix + score.ToString();
    }
    #endregion
}
