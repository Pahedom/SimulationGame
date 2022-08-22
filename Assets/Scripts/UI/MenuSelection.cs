using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MenuSelection : MonoBehaviour
    {
        [SerializeField] private int firstMenu;

        [SerializeField] private Menu[] menus;

        [SerializeField] private Color selectedColor;
        [SerializeField] private Color unselectedColor;

        private GameObject activeMenu;

        [Serializable]
        private struct Menu
        {
            public GameObject menu;
            public Image button;
            public Image[] items;
            internal Image selectedItem;
        }

        void Start()
        {
            SelectMenu(menus[firstMenu].menu);
        }

        public void SelectMenu(GameObject menu)
        {
            foreach (Menu item in menus)
            {
                if (item.menu == menu)
                {
                    item.menu.SetActive(true);
                    item.button.color = selectedColor;
                    activeMenu = item.menu;

                    if (item.selectedItem == null)
                    {
                        SelectItem(item.items[0].gameObject);
                    }
                }
                else
                {
                    item.menu.SetActive(false);
                    item.button.color = unselectedColor;
                }
            }
        }

        public void SelectItem(GameObject item)
        {
            for (int i = 0; i < menus.Length; i++)
            {
                foreach (Image image in menus[i].items)
                {
                    if (image.gameObject == item)
                    {
                        image.color = selectedColor;
                        menus[i].selectedItem = image;
                    }
                    else if (menus[i].menu == activeMenu)
                    {
                        image.color = unselectedColor;
                    }
                }
            }
        }
    }
}