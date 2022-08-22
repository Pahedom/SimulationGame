using System;
using UnityEngine;

namespace Player
{
    public class PlayerStats : MonoBehaviour
    {
        public int money { get; private set; } = 9999;

        public Action OnMoneyValueChanged;

        public void AddMoney(int value)
        {
            money += value;

            OnMoneyValueChanged?.Invoke();
        }

        public void RemoveMoney(int value)
        {
            money -= value;

            OnMoneyValueChanged?.Invoke();
        }
    }
}