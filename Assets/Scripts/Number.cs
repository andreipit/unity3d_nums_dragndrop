using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Number : MonoBehaviour
    {
        public Text text;
        public bool isMoving;
        public static int maxValue;
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
            int newValue = int.Parse(text.text) + value;
            text.text = (newValue).ToString();
            if (newValue > maxValue) maxValue = newValue;
        }
    }
}
