using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts
{
    public class Main : MonoBehaviour
    {
        BaseTrader trader;

        FruitTrader fruitTrader;
        ArmorTrader armorTrader;
        NoTradeTrader noTrade;

        int reputation = 50;

        private void Start()
        {
            fruitTrader = new FruitTrader();
            armorTrader= new ArmorTrader();
            noTrade = new NoTradeTrader();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                trader = fruitTrader;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                trader = armorTrader;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                trader = noTrade;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                trader.Trade();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                reputation -= 10;
                Debug.Log(reputation);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                reputation += 10;
                Debug.Log(reputation);
            }
        }
    }
}