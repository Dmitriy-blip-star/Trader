using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class NoTradeTrader : BaseTrader
    {
        protected override void SelectGoods()
        {
            Debug.Log("No trade");
        }
    }
}