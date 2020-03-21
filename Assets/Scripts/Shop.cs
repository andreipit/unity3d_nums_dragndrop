using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Shop : MonoBehaviour
    {
        public GameObject prefab;

        void Start()
        {

            for (int i = 1; i <= 100; i++)
            {
                GameObject item = Instantiate(prefab, transform);
                item.GetComponent<ShopItem>().id = i;
                item.transform.Find("name").GetComponent<Text>().text = Language.words[4].value;
            }

        }

    }
}
