using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Cell : MonoBehaviour
    {
        public Text text;

        void Awake()
        {
            text = GetComponentInChildren<Text>();
        }

    }
}


