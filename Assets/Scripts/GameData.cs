using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public double money;
    public double starMultiplier;
    public double resetMultiplier;

    public GameData(string moneys, string stars, string respect)
    {
        money = Convert.ToDouble(moneys);
        starMultiplier = Convert.ToDouble(stars);
        resetMultiplier = Convert.ToDouble(respect);

    }
}
