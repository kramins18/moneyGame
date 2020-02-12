
using System;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   /* // Start is called before the first frame update
    public float moneyMultiplayer = 1;
    public GameObject GamePanelUpdater;
    public GameObject[] storeCollection;
    private StoreController sc;
    

    void Start()
    {
        moneyMultiplayer = 1;
        sc = GamePanelUpdater.GetComponent<StoreController>();
        GameData gd = SaveSystem.loadGame();

   

        StoreData[] s = SaveSystem.loadStoreData();
        for (int i = 0; i < storeCollection.Length; i++)
       {
           updateStores(storeCollection[i].GetComponent<StoreController>(), s[i]);
       }
        
    }

    void updateStores(StoreController storCont, StoreData storData)
    {
        storCont.storeLevel.text = storData.storeLevel;

       
        storCont.star1Animator.SetBool("StarGained", storData.star1);
        storCont.star2Animator.SetBool("StarGained", storData.star2);
        storCont.star3Animator.SetBool("StarGained", storData.star3);

        storCont.moneyPerCycle = storData.moneyPerCycle;
        if (storCont.storeLevel.text!="MAX")
        {
            
            storCont.upgradeCost = Convert.ToDouble(storData.upgradeCost);
            storCont.upgradeButtonCostText.text = storData.upgradeCost;
        }
        else
        {
            storCont.upgradeButtonCostText.text = "MAX";
        }
       // storCont.ProgressBarMoneyperTime.text = (storData.moneyPerCycle / storData.oneCycleTime).ToString("0.00");
        storCont.oneCycleTime = storData.oneCycleTime;
        storCont.timerText.text = storData.oneCycleTime.ToString("0.00");
        storCont.ProgressBarMoneyperTime.text = (storData.moneyPerCycle / storData.oneCycleTime).ToString("0.00");




        storCont.progressSlider.value = (float)(10 - storData.levelsLeftToAdvance) * 0.1f;
        
        





    }
    void OnApplicationQuit()
    {
        StoreController[] storeControlers= new StoreController[storeCollection.Length];
        for (int i = 0; i < storeCollection.Length; i++)
        {
            storeControlers[i] = storeCollection[i].GetComponent<StoreController>();

        }



    }

    
    string prepeareSting()
    {
        String s = "";
        return s;*/
    

}

 