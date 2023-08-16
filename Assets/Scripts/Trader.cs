using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Trader : BaseTrader
    {
        protected override void DontTrade()
        {
            Debug.Log("I'll not trade with you");
        }

        protected override void ArmorTrade()
        {
            Debug.Log("I'll trade you the armor");
        }

        protected override void FruitTrade()
        {
            Debug.Log("I'll trade you the fruits");
        }
    }
}