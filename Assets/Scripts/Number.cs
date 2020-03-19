﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Number : MonoBehaviour
    {
        public Text text;
        public bool isMoving;
        public int value { get { return (text.text == "") ? 0 : int.Parse(text.text); } }

        void Start()
        {
            text = GetComponentInChildren<Text>();
        }

        public void Delete()
        {
            text.text = "";
        }

        public void Increase(int value)
        {
            text.text = (int.Parse(text.text) + value).ToString();
        }
    }
}
