using Player;
using TMPro;
using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class MoneyDisplay : MonoBehaviour
    {
        private PlayerStats player;

        private TextMeshProUGUI text;

        void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

            text = GetComponent<TextMeshProUGUI>();

            player.OnMoneyValueChanged += UpdateDisplay;

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            text.text = player.money.ToString();
        }
    }
}