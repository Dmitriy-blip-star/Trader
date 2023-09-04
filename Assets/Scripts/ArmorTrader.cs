using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class ArmorTrader : BaseTrader
    {
        protected override void SelectGoods()
        {
            Debug.Log("Sell armor");
        }
    }
}