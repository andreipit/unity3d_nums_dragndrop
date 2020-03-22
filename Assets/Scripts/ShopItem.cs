using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class ShopItem : MonoBehaviour
    {
        public int id;
        public float price;
        public int purchases;
        public Text idText;
        public Text priceText;
        
        private void Start()
        {
            UpdatePrice();
            idText.text = id.ToString();
            priceText.text = price.ToString();
        }

        void UpdatePrice()
        {
            price = id * 100 * Mathf.Pow(purchases + 1, 2);
        }

        public void Buy()
        {
            if (Points.value >= price && Spawner.instance.cellsEmpty.Count > 0)
            {
                Spawner.instance.Spawn(id);
                Points.value -= price;
                Points.instance.UpdateText();
                UpdatePrice();
                if (id > Number.maxValue) Number.maxValue = id;
            }
        }
    }
}
