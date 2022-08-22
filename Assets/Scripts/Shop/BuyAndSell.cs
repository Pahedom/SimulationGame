using Player;
using UI;
using UnityEngine;

namespace Shop
{
    public class BuyAndSell : MonoBehaviour
    {
        [SerializeField] private BuyableItem[] items;

        [SerializeField] private MenuSelection selection;

        private PlayerStats player;

        private void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

            SetSellableItems();
        }

        public void Buy(BuyableItem item)
        {
            if (item.value > player.money)
            {
                return;
            }

            if (!item.owned)
            {
                item.owned = true;

                item.valueDisplay.gameObject.SetActive(false);

                SetSellableItems();

                player.RemoveMoney(item.value);
            }

            selection.SelectItem(item.gameObject);

            foreach (BuyableItem buyableItem in items)
            {
                buyableItem.equipped = false;
            }

            item.Equip();
        }

        public void Sell(BuyableItem item)
        {
            item.owned = false;

            player.AddMoney(item.value);

            item.valueDisplay.gameObject.SetActive(true);

            SetSellableItems();

            if (!item.equipped)
            {
                return;
            }

            item.equipped = false;

            foreach (BuyableItem buyableItem in items)
            {
                if (buyableItem.owned)
                {
                    selection.SelectItem(buyableItem.gameObject);

                    buyableItem.Equip();

                    break;
                }
            }
        }

        private void SetSellableItems()
        {
            int ownedItems = 0;

            foreach (BuyableItem item in items)
            {
                if (item.owned)
                {
                    ownedItems++;
                }
            }

            bool sellable = ownedItems >= 2;

            foreach (BuyableItem item in items)
            {
                item.SetSellable(sellable);
            }
        }
    }
}