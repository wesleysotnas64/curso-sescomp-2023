using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public Text txtTime;
    public Text txtScore;
    public float initTime;
    public float currentTime;
    public int currentScore;
    void Start()
    {
        currentTime = initTime;
    }

    void Update()
    {
        RunTime();
        UpdateUI();
    }

    public void ToScore()
    {
        currentScore++;

        SaveData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Score", currentScore);

        if(currentScore > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", currentScore);
    }

    private void RunTime()
    {
        currentTime -= Time.deltaTime;
    }

    private void UpdateUI()
    {
        txtTime.text  = "Time: " + ((int)currentTime).ToString();
        txtScore.text = "Score: " + currentScore.ToString();
    }

}
