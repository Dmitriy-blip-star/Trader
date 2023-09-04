using System;
using UnityEngine;

public abstract class BaseTrader : MonoBehaviour
{
    public void Trade()
    {
        SelectGoods();
        NegotiatePrice();
        PrintReceipt();
    }

    protected abstract void SelectGoods();

    protected void NegotiatePrice()
    {
        Debug.Log("Negotiate for the price");
    }

    protected void PrintReceipt()
    {
        Debug.Log("Print receipt");
    }
}
