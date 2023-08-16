using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts
{
    public class Main : MonoBehaviour
    {
        Trader trader = new Trader();

        int reputation = 50;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                trader.Trade(reputation);
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