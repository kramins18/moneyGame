using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoreController : MonoBehaviour
{
    /* public GameObject gameManager;


     public Button storeActivator;

     public bool storeIsOpen;
     public float oneCycleTime;
     private float CurrentCycleTime = 0;
     public float oneCycleTimeMinus = 0.4f;

     public bool storeHasManager;
     public bool storeIsRunning ;

     public Slider slider;
     public double moneyPerCycle = 5;

     public Text storeLevel;

     public Text ProgressBarMoneyperTime;
     public Text timerText;


     public Animator star1Animator;
     public Animator star2Animator;
     public Animator star3Animator;


     public Animator ManigerAnimator;


     public Slider progressSlider;
     public int levelsLeftToAdvance =10;


     */



    //--->OPEN CLOSE STORE VARIABLES<---//
    private GameObject openShopGameObject;
    private Button openStoreBtn;

    //--->STORE MANAGAR VARIABLES<---//
    private bool storeHasManager ;
    private Button ManangerActivationBtn;




    // Start is called before the first frame update

    [Obsolete]
    void Start()
    {
        ShopOpenCloseBtnFunctionality();
        ManagerButtonFunctuallity();
        

       // Application.LoadLevelAdditive(1);
      
        //SceneManager.LoadScene(1);










        // storeActivator.onClick.AddListener(storeCycle);


        // ProgressBarMoneyperTime.text = (moneyPerCycle / oneCycleTime).ToString("0.00");





    }
    //--->OPEN CLOSE STORE FUNCTIONS<---//
    void ShopOpenCloseBtnFunctionality()
    {
        openShopGameObject = GameObject.Find("ShopOpen");      
        openStoreBtn = GameObject.Find("openStoreBtn").GetComponent<Button>(); ;
        openStoreBtn.onClick.AddListener(delegate { OpenCloseStoreScreen(true); });

    }
    void OpenCloseStoreScreen(bool whatToDo)
    {
        openShopGameObject.SetActive(whatToDo);
    }


    //--->Store Manager Functions<---//
    void ManagerButtonFunctuallity()
    {
        
        if (storeHasManager)
        {
            ReplaceManagarShadowWithManager();
        }else
        {
                     
        }
       



    }
    void ReplaceManagarShadowWithManager()
    {
        

    }
    void AddManager()
    {
        storeHasManager = true;
        ReplaceManagarShadowWithManager();
    }
    void OpenManagersScreen()
    {
        print("Byttclick");
        //// TO DO : opens screen with managers
        AddManager();
    }











































    //Update is called once per frame
    /*
    void Update()
    {
     
        if (storeIsOpen)
        {
            if (storeHasManager)
            {
                if (!storeIsRunning)
                {
                    storeCycle();
                }
            }
          
         
        }
       // print(timerText.text);
        if (storeIsRunning)
        {
            storeCycle();
        }


        if (upgradeCost> GameStatPanelControler.gameStatsMoney || storeLevel.text == "MAX")
        {
            upgradeButton.interactable = false;
        }
        else
        {
            upgradeButton.interactable = true;
        }
        
        
    }
    //open store
    void RemoveThisButtonFromScreen()
    {
        levelsLeftToAdvance--;
        progressSlider.value = 0.1f;
        storeLevel.text = "1";
        storeIsOpen = true;
      
    }
    void UpgradeStore()
    {
        print("store upgrade");
        if (Convert.ToDouble(GameStatPanelControler.gameStatsMoney) >= upgradeCost)
        {

          
            gm.SetActive(!gm.activeInHierarchy);
            //a.transform.parent = null;
            //SceneManager.LoadScene("GunShopUpgradeSceen");
            //SceneManager.MoveGameObjectToScene(a, SceneManager.GetSceneByName("GunShopUpgradeSceen"));
            //GameStatPanelControler.PurchaseStoreUpgrade(upgradeCost);
            //upgrade price incriace
            upgradeCost += 10;
            upgradeButtonCostText.text = upgradeCost.ToString();

            //money per cycle
            moneyPerCycle += 3;



            // change money per second

            ProgressBarMoneyperTime.text = "$" + Math.Round((moneyPerCycle / oneCycleTime), 2).ToString() + " /s";

            //change Level
            storeLevel.text = (Convert.ToInt16(storeLevel.text) + 1).ToString();
            


            //starAnimatorFunction;
             if (storeLevel.text == "30")
             {
                star1Animator.SetBool("StarGained", true);
                GameStatPanelControler.StarMultiplierGained();
             }
            if (storeLevel.text == "60")
            {
                star2Animator.SetBool("StarGained", true);              
                GameStatPanelControler.StarMultiplierGained();
            }
            if (storeLevel.text == "100")
            {
                star3Animator.SetBool("StarGained", true);
                GameStatPanelControler.StarMultiplierGained();
            }


            //progressSlider
            print(levelsLeftToAdvance);
            levelsLeftToAdvance--;

            if (levelsLeftToAdvance==0)
            {
                levelsLeftToAdvance = 10;
                oneCycleTime = oneCycleTime - oneCycleTimeMinus;
                timerText.text = oneCycleTime.ToString("0.00");
                if (storeLevel.text == "100")
                {
                    levelsLeftToAdvance = 0;
                }
            }

            progressSlider.value = (float)(10 - levelsLeftToAdvance)* 0.1f;
            



            ////maxLEveLREached

            if (storeLevel.text == "100")
            {
                storeLevel.text = "MAX";
                upgradeButton.interactable = false;
                upgradeButton.GetComponentInChildren<Text>().text = "MAX";
                



            }

            
        }
    }
   
    void ActivateManager()
    {
        if (!storeHasManager)
        {
            storeHasManager = true;
            ManigerAnimator.SetBool("hasManager", true);
        }
    }
    void storeCycle()
    {
   
        storeIsRunning = true;
        if (CurrentCycleTime <= oneCycleTime)
        {
            CurrentCycleTime += Time.deltaTime;

        }
            //Store completed cycle
        else
        {

            
             gameStatPanelMoney.text = (
                                         Convert.ToDouble(gameStatPanelMoney.text) +
                                         moneyPerCycle * Convert.ToDouble(starCounter.text)
                                       ).ToString();
            CurrentCycleTime = 0;
            storeIsRunning = false;
            GameStatPanelControler.AddStoreIncomeToGameStats(10);


        }
        slider.value = CurrentCycleTime / oneCycleTime;
        if ((oneCycleTime - CurrentCycleTime).ToString().Length>3)
        {
            timerText.text = (oneCycleTime - CurrentCycleTime).ToString("0.00");
        }
        else
        {
            timerText.text = oneCycleTime.ToString();
        }

        
    
    */

}
