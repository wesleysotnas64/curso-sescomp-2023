using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Text txtHighScore;
    public Text txtScore;
    private void Start()
    {
        UpdateUI();
    }

    private void Update() {
        if (Input.GetKeyDown("r")) SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }

    private void UpdateUI()
    {
        txtHighScore.text  = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        txtScore.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
    }

}
