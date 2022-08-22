using Player;
using Shop;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CustomizePlayer : MonoBehaviour
    {
        [SerializeField] private Image hood;
        [SerializeField] private Image torso;
        [SerializeField] private Image waist;
        [SerializeField] private Image shoulderL;
        [SerializeField] private Image shoulderR;
        [SerializeField] private Image elbowL;
        [SerializeField] private Image elbowR;
        [SerializeField] private Image wristR;
        [SerializeField] private Image wristL;
        [SerializeField] private Image legL;
        [SerializeField] private Image legR;
        [SerializeField] private Image bootL;
        [SerializeField] private Image bootR;

        private Customize player;

        private void Awake()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Customize>();

            if (player == null)
            {
                player = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Customize>();
            }
        }

        public void ChangeHood(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image image = obj.item.GetComponentInChildren<Image>();
            player.ChangeHood(image.sprite);
            hood.sprite = image.sprite;
        }

        public void ChangeTorso(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image image = obj.item.GetComponentInChildren<Image>();
            player.ChangeTorso(image.sprite);
            torso.sprite = image.sprite;
        }

        public void ChangeWaist(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image image = obj.item.GetComponentInChildren<Image>();
            player.ChangeWaist(image.sprite);
            waist.sprite = image.sprite;
        }

        public void ChangeShoulders(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image[] images = obj.item.GetComponentsInChildren<Image>();
            player.ChangeShoulders(images[0].sprite, images[1].sprite);
            shoulderL.sprite = images[0].sprite;
            shoulderR.sprite = images[1].sprite;
        }

        public void ChangeElbows(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image[] images = obj.item.GetComponentsInChildren<Image>();
            player.ChangeElbows(images[0].sprite, images[1].sprite);
            elbowL.sprite = images[0].sprite;
            elbowR.sprite = images[1].sprite;
        }

        public void ChangeWrists(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image[] images = obj.item.GetComponentsInChildren<Image>();
            player.ChangeWrists(images[0].sprite, images[1].sprite);
            wristL.sprite = images[0].sprite;
            wristR.sprite = images[1].sprite;
        }

        public void ChangeLegs(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image[] images = obj.item.GetComponentsInChildren<Image>();
            player.ChangeLegs(images[0].sprite, images[1].sprite);
            legL.sprite = images[0].sprite;
            legR.sprite = images[1].sprite;
        }

        public void ChangeBoots(BuyableItem obj)
        {
            if (!obj.owned)
            {
                return;
            }
            Image[] images = obj.item.GetComponentsInChildren<Image>();
            player.ChangeBoots(images[0].sprite, images[1].sprite);
            bootL.sprite = images[0].sprite;
            bootR.sprite = images[1].sprite;
        }
    }
}