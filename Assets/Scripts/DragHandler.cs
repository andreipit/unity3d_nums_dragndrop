using UnityEngine;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class DragHandler : MonoBehaviour
    {
        Vector3 pos;
        Number number;

        void Start()
        {
            pos = transform.localPosition;
            number = GetComponent<Number>();
        }
        public void Drag()
        {
            if (number.isMoving) transform.position = Input.mousePosition;
        }

        public void InitPotenDrag()
        {
            transform.position = Input.mousePosition;
            number.isMoving = true;
        }
    }
}