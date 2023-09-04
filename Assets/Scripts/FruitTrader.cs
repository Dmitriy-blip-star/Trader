using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class FruitTrader : BaseTrader
    {
        protected override void SelectGoods()
        {
            Debug.Log("Sell fruit");
        }
    }
}