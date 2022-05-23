using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowMyPrize : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private int coins;

    [SerializeField] private Text prize1Text;
    [SerializeField] private Text prize2Text;
    [SerializeField] private Text prize3Text;

    public int rezult;

    private string[] discount = new string[] {
        "Билет на розыгрыш скидки в 1% на любую путевку!",
        "Билет на розыгрыш скидки в 3% на любую путевку!",
        "Билет на розыгрыш скидки в 5% на любую путевку!",
        "Билет на розыгрыш скидки в 8% на любую путевку!",
        "Билет на розыгрыш скидки в 10% на любую путевку!",
        "Билет на розыгрыш скидки в 12% на любую путевку!",
        "Билет на розыгрыш скидки в 15% на любую путевку!",
        "Билет на розыгрыш скидки в 20% на любую путевку!",
        "Билет на розыгрыш скидки в 25% на любую путевку!",
        "Билет на розыгрыш скидки в 100% на любую путевку!"}; 

    private string[] promo = new string[] {
        "Билет на розыгрыш промокода на 1000 руб!",
        "Билет на розыгрыш промокода на 2500 руб!",
        "Билет на розыгрыш промокода на 5000 руб!",
        "Билет на розыгрыш промокода на 8000 руб!",
        "Билет на розыгрыш промокода на 10000 руб!",
        "Билет на розыгрыш промокода на 15000 руб!",
        "Билет на розыгрыш промокода на 20000 руб!",
        "Билет на розыгрыш промокода на 25000 руб!",
        "Билет на розыгрыш промокода на 50000 руб!",
        "Билет на розыгрыш промокода на 100000 руб!"}; 

    private string[] coin = new string[] {
        "+5 Coins",
        "+10 Coins",
        "+15 Coins",
        "+20 Coins",
        "+25 Coins",
        "+30 Coins",
        "+40 Coins",
        "+50 Coins",
        "+100 Coins",
        "+1000 Coins"}; 

    private void Start()
    {
        coins = PlayerPrefs.GetInt("coins");

        int box = PlayerPrefs.GetInt("buybox");

        if (box == 1) {
            rezult = (Random.Range(0,discount.Length-6));
        }
        else if (box == 2) {
            rezult = (Random.Range(0,discount.Length-4));
        }
        else if (box == 3) {
            rezult = (Random.Range(0,discount.Length-2));
        }
        else if (box == 4) {
            rezult = (Random.Range(0,discount.Length));
        }
        else if (box == 5) {
            rezult = (Random.Range(0,discount.Length-9));
        }

        for (int i = 0; i < 3; i++) {
            if (i == 0) {
                PlayerPrefs.SetInt("prize1", rezult);
                prize1Text.text = discount[rezult].ToString();
            }
            else if (i == 1) {
                PlayerPrefs.SetInt("prize2", rezult);
                prize2Text.text = promo[rezult].ToString();
            }
            else if (i == 2) {
                PlayerPrefs.SetInt("prize3", rezult);
                prize3Text.text = coin[rezult].ToString();
                if (rezult <= 3) {
                    coins += 5 * (rezult + 1);
                }
                else {
                    if (rezult == 4) {
                        coins += 40;
                    }
                    else if (rezult == 5) {
                        coins += 50;
                    }
                    else if (rezult == 6) {
                        coins += 100;
                    }
                    else if (rezult == 7) {
                        coins += 1000;
                    }
                }
            }
        }    
        PlayerPrefs.SetInt("coins", coins);
        coinsText.text = coins.ToString() + " coins";   
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void MyPrize() {
        SceneManager.LoadScene(4);
    }

    public void Magazine() {
        SceneManager.LoadScene(2);
    }
}
