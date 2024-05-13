using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void ScorePoint()
    {
        score++;
    }
}
