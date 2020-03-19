using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Logic : MonoBehaviour
    {
        public GameObject store;

        public void ToggleStore(bool show)
        {
            store.SetActive(show);
            if (show)
            {
                Debug.Log("open store");
            }
            else
            {
                Debug.Log("close store");
            }
        }
    }
}
