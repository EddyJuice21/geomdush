using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    [SerializeField] private TMP_Text scoreText;
    private int score;

    public void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Дублирование ScoreManager");
            Destroy(Instance);
        }
    }

    public void AddScore(int score)
    {
        this.score += score; 
        scoreText.text = this.score.ToString();
    }


}
