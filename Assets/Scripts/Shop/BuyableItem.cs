using TMPro;
using UI;
using UnityEngine;

namespace Shop
{
    public class BuyableItem : MonoBehaviour
    {
        public bool owned;

        public bool equipped;

        public int value;

        public enum ItemType
        {
            Hood,
            Torso,
            Waist,
            Shoulders,
            Elbows,
            Wrists,
            Legs,
            Boots
        }

        public ItemType type;

        public GameObject item;

        public TextMeshProUGUI valueDisplay;

        [SerializeField] private GameObject sellButton;

        private CustomizePlayer player;

        private void Awake()
        {
            player = FindObjectOfType<CustomizePlayer>();

            valueDisplay.text = value.ToString();

            valueDisplay.gameObject.SetActive(!owned);
        }

        public void SetSellable(bool set)
        {
            if (!owned)
            {
                set = false;
            }

            sellButton.SetActive(set);
        }

        public void Buy()
        {
            GetComponentInParent<BuyAndSell>().Buy(this);
        }

        public void Sell()
        {
            GetComponentInParent<BuyAndSell>().Sell(this);
        }

        public void Equip()
        {
            equipped = true;

            if (type == ItemType.Hood)
            {
                player.ChangeHood(this);
            }
            else if (type == ItemType.Torso)
            {
                player.ChangeTorso(this);
            }
            else if (type == ItemType.Waist)
            {
                player.ChangeWaist(this);
            }
            else if (type == ItemType.Shoulders)
            {
                player.ChangeShoulders(this);
            }
            else if (type == ItemType.Elbows)
            {
                player.ChangeElbows(this);
            }
            else if (type == ItemType.Wrists)
            {
                player.ChangeWrists(this);
            }
            else if (type == ItemType.Legs)
            {
                player.ChangeLegs(this);
            }
            else if (type == ItemType.Boots)
            {
                player.ChangeBoots(this);
            }
        }
    }
}