using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testScript : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(s);
    }
    //just changes something here

    public void s()
    {
        GameStatPanelControler.AddStoreIncomeToGameStats(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
