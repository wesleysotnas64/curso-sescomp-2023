using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Text txtHighScore;
    public Text txtScore;
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        txtHighScore.text  = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        txtScore.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
    }

}
