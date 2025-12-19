using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;

    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindFirstObjectByType<ScoreKeeper>();
    }

    void Start()
    {
        ScoreText.text = "FINAL SCORE:\n" + scoreKeeper.GetScore();
    }
}
