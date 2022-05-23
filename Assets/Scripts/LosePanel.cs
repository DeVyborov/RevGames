using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    [SerializeField] Text recordText;

    private void Update()
    {
        int lastRunScore = PlayerPrefs.GetInt("lastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");

        if (lastRunScore > recordScore)
        {
            PlayerPrefs.SetInt("recordScore", lastRunScore);
            recordText.text = "Ваш рекорд: " + lastRunScore.ToString() + " km";
        }
        else
        {
            recordText.text = "Ваш рекорд: " + recordScore.ToString() + " km";
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
