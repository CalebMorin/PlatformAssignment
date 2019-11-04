using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameController : MonoBehaviour
{
    [Header("UI Settings")]
    public Text ScoreLabel;
    public int score = 0;
    public void Update()
    {
        ScoreLabel.text = "Score, Babey: " + score.ToString();
    }
}
