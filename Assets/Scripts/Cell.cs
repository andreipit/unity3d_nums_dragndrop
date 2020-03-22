using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Cell : MonoBehaviour
    {
        public Text text;

        public void SetNumber(int value)
        {
            text.text = value.ToString();
        }
    }
}


