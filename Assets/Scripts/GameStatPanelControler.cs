using System;
using UnityEngine;
using UnityEngine.UI;


public class GameStatPanelControler : MonoBehaviour
{
    public static double gameStatsMoney;
    public static double gameStatsStarMultiplier;
    public static double gameStatsResetMultiplier;
    private static Text gameStatsMoneyText;
    private static Text gameStatsStarMultiplierText;
    private static Text gameStatsResetMultiplierText;
    void Start()
    {
        gameStatsMoneyText = GameObject.Find("TxtMoney").GetComponent<Text>();
        gameStatsStarMultiplierText = GameObject.Find("TxtStars").GetComponent<Text>();
        gameStatsResetMultiplierText = GameObject.Find("TxtReset").GetComponent<Text>();
        gameStatsMoney = 200;
        gameStatsResetMultiplier = 1;
        gameStatsStarMultiplier = 1;
        
        loadGamePanelsData();
        



    }
    private void Update()
    {
        OpenShopController.SellItems();
    }
    //USED from Stores To ADD Income;
    public static void AddStoreIncomeToGameStats(double storeIncomePerCycle)
    {
        //gameStatsMoney += (storeIncomePerCycle * gameStatsStarMultiplier * gameStatsResetMultiplier);
        gameStatsMoney += storeIncomePerCycle;
        gameStatsMoneyText.text = gameStatsMoney.ToString("0.00");
       
    }
    public static void PurchaseStoreUpgrade(double cost)
    {
        gameStatsMoney -= (cost);

        gameStatsMoneyText.text = gameStatsMoney.ToString("0.00");
    }
    public static void StarMultiplierGained()
    {
        gameStatsStarMultiplier += 0.1;
        gameStatsStarMultiplierText.text = gameStatsStarMultiplier.ToString("0.00");
    }







    private void loadGamePanelsData()
    {
       
        GameData gd = SaveSystem.loadGame();
        gameStatsMoney = gd.money;
        gameStatsStarMultiplier = gd.starMultiplier;
        gameStatsResetMultiplier = gd.resetMultiplier;

        gameStatsMoneyText.text = gameStatsMoney.ToString("0.00");
        gameStatsStarMultiplierText.text = gameStatsStarMultiplier.ToString("0.00");
        gameStatsResetMultiplierText.text = gameStatsResetMultiplier.ToString("0.00");


    }
    private void OnApplicationQuit()
    {

        SaveSystem.saveGame(new GameData(gameStatsMoneyText.text,
                                         gameStatsStarMultiplierText.text,
                                         gameStatsResetMultiplierText.text));
  
    }
}
