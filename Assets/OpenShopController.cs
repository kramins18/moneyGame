using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item
{
    public double importPrice;
    public double sellPrice;
    public int itemCount;

}
public class OpenShopController : MonoBehaviour
{
    
    public static item[] ItemArray= new item[1];
    public static void SellItems()
    {
        foreach (var item in ItemArray)
        {
            if (item.itemCount > 0)
            {
                item.itemCount--;
                GameStatPanelControler.AddStoreIncomeToGameStats(item.sellPrice);
            }
        }
    }

    void Start()
    {
        ItemArray[0] = new item();
        ItemArray[0].importPrice = 5;
        ItemArray[0].sellPrice = 7;
        ItemArray[0].itemCount = 3;
    }
    public static void ADD(int count)
    {
        ItemArray[0].itemCount += count;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
