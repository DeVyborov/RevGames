using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void Start() {
        System.DateTime dateBuy = System.DateTime.Now;
        PlayerPrefs.SetString("dateBuy", dateBuy.ToString()); 

        System.DateTime trueDate = System.DateTime.Now;
        PlayerPrefs.SetString("trueDate", trueDate.ToString()); 
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowMagazine() {
        SceneManager.LoadScene(2);
    }

    public void MyPrize() {
        SceneManager.LoadScene(4);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
