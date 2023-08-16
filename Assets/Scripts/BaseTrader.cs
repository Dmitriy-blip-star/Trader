using System;
using UnityEngine;

public abstract class BaseTrader : MonoBehaviour
{
    public void Trade(int reputation)
    {

        if (reputation >= 75)
        {
            ArmorTrade();
        }
        else if (reputation >= 50)
        {
            FruitTrade();
        }
        else
        {
            DontTrade();
        }
    }

    protected abstract void DontTrade();

    protected abstract void FruitTrade();

    protected abstract void ArmorTrade();
}
