using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MyPrize : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private Text prize1Text;
    [SerializeField] private Text prize2Text;
    [SerializeField] private Text prize3Text;
    [SerializeField] private int coins;

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
        coinsText.text = coins.ToString() + " coins";

        prize1Text.text = discount[PlayerPrefs.GetInt("prize1")].ToString();
        prize2Text.text = promo[PlayerPrefs.GetInt("prize2")].ToString();
        prize3Text.text = coin[PlayerPrefs.GetInt("prize3")].ToString();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
