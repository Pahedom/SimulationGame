using UnityEngine;

namespace Player
{
    public class Customize : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer hood;
        [SerializeField] private SpriteRenderer torso;
        [SerializeField] private SpriteRenderer waist;
        [SerializeField] private SpriteRenderer shoulderL;
        [SerializeField] private SpriteRenderer shoulderR;
        [SerializeField] private SpriteRenderer elbowL;
        [SerializeField] private SpriteRenderer elbowR;
        [SerializeField] private SpriteRenderer wristR;
        [SerializeField] private SpriteRenderer wristL;
        [SerializeField] private SpriteRenderer legL;
        [SerializeField] private SpriteRenderer legR;
        [SerializeField] private SpriteRenderer bootL;
        [SerializeField] private SpriteRenderer bootR;

        public void ChangeHood(Sprite sprite)
        {
            hood.sprite = sprite;
        }

        public void ChangeTorso(Sprite sprite)
        {
            torso.sprite = sprite;
        }

        public void ChangeWaist(Sprite sprite)
        {
            waist.sprite = sprite;
        }

        public void ChangeShoulders(Sprite spriteL, Sprite spriteR)
        {
            shoulderL.sprite = spriteL;
            shoulderR.sprite = spriteR;
        }

        public void ChangeElbows(Sprite spriteL, Sprite spriteR)
        {
            elbowL.sprite = spriteL;
            elbowR.sprite = spriteR;
        }

        public void ChangeWrists(Sprite spriteL, Sprite spriteR)
        {
            wristL.sprite = spriteL;
            wristR.sprite = spriteR;
        }

        public void ChangeLegs(Sprite spriteL, Sprite spriteR)
        {
            legL.sprite = spriteL;
            legR.sprite = spriteR;
        }

        public void ChangeBoots(Sprite spriteL, Sprite spriteR)
        {
            bootL.sprite = spriteL;
            bootR.sprite = spriteR;
        }
    }
}