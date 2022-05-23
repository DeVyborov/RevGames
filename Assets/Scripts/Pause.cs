using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject stopPanel;

    public void ButtonPause() {
            stopPanel.SetActive(true);
            Time.timeScale = 0;
    }

    public void Resume() {
            stopPanel.SetActive(false);
            Time.timeScale = 1;
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
