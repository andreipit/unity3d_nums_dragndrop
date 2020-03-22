using UnityEngine.UI;
using UnityEngine;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Points : MonoBehaviour
    {
        public static float value = 50;
        public static Points instance;
        float multiplier = 0.5f;
        Text text;

        void Start()
        {
            text = GetComponent<Text>();
            UpdateText();
            instance = this;
        }

        public void Increase()
        {
            value += (int)value * multiplier;
            multiplier = (multiplier == 0.5f) ? (1f / 3f) : 0.5f;
            UpdateText();
        }

        public void UpdateText()
        {
            text.text = "" + value.ToString();
        }
    }
}