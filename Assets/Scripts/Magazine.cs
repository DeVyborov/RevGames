using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Magazine : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private int coins;
    [SerializeField] private GameObject blockPanel;
    [SerializeField] private GameObject timePanel;
    private void Start()
    {      
        coins = PlayerPrefs.GetInt("coins");
        //coins += 1000;
        //PlayerPrefs.SetInt("coins", coins);
        coinsText.text = coins.ToString() + " coins";
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowMagazine()
    {
        SceneManager.LoadScene(1);
    }

    public void BuyBoxTime() {
        System.DateTime dateBuy = DateTime.Parse(PlayerPrefs.GetString("dateBuy"));
        System.DateTime trueDate = DateTime.Parse(PlayerPrefs.GetString("trueDate"));

        if (dateBuy >= trueDate) {
            dateBuy = System.DateTime.Now;
            PlayerPrefs.SetString("dateBuy", dateBuy.ToString());  

            trueDate = System.DateTime.Now.AddHours(24);
            PlayerPrefs.SetString("trueDate", trueDate.ToString());  

            SceneManager.LoadScene(3);
            PlayerPrefs.SetInt("buybox", 5);  
        }
        else {
            timePanel.SetActive(true); 
        }    
    }

    public void BuyBox1() {

        if (coins >= 50) {
            coins -= 50;
            coinsText.text = coins.ToString() + " coins";
            PlayerPrefs.SetInt("coins", coins);
            SceneManager.LoadScene(3);

            PlayerPrefs.SetInt("buybox", 1);
        } 
        else {
            blockPanel.SetActive(true);
        }      
    }

    public void BuyBox2() {

        if (coins >= 100) {
            coins -= 100;
            coinsText.text = coins.ToString() + " coins";
            PlayerPrefs.SetInt("coins", coins);
            SceneManager.LoadScene(3);

            PlayerPrefs.SetInt("buybox", 2);
        } 
        else {
            blockPanel.SetActive(true);
        }      
    }

    public void BuyBox3() {

        if (coins >= 200) {
            coins -= 200;
            coinsText.text = coins.ToString() + " coins";
            PlayerPrefs.SetInt("coins", coins);
            SceneManager.LoadScene(3);

            PlayerPrefs.SetInt("buybox", 3);
        } 
        else {
            blockPanel.SetActive(true);
        }      
    }

    public void BuyBox4() {

        if (coins >= 500) {
            coins -= 500;
            coinsText.text = coins.ToString() + " coins";
            PlayerPrefs.SetInt("coins", coins);
            SceneManager.LoadScene(3);

            PlayerPrefs.SetInt("buybox", 4);
        } 
        else {
            blockPanel.SetActive(true);
        }      
    }

    public void MyPrize() {
        SceneManager.LoadScene(4);
    }

    public void CloseBlock() {
        blockPanel.SetActive(false);
    }

    public void CloseTime() {
        timePanel.SetActive(false);
    }
}
