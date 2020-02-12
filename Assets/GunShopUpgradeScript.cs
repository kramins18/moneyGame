using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShopUpgradeScript : MonoBehaviour
{
    public Animator shopAssistantAnimator;
    // Start is called before the first frame update
    void Start()
    {
        shopAssistantAnimator.SetBool("hasManager", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
