using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        FollowPlayer();
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
        if(currentTime <= 0)
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

    private void UpdateUI()
    {
        txtTime.text  = "Time: " + ((int)currentTime).ToString();
        txtScore.text = "Score: " + currentScore.ToString();
    }

    private void FollowPlayer()
    {
        Vector2 playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;
        Vector2 camPosition = transform.position;

        Vector2 currentPosition = Vector2.Lerp(camPosition, playerPosition, Time.deltaTime);

        transform.position = new Vector3(currentPosition.x, currentPosition.y, -10);
    }

}
