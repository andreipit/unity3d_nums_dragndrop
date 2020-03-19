using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{ 
    public class DropHandler : MonoBehaviour
    {
        Vector3 pos;
        Number number;

        void Start()
        {
            pos = transform.localPosition;
            number = GetComponent<Number>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (number.isMoving) // all calculations are only on moving number
            {
                Number staticNumber = collision.GetComponent<Number>();
                if (staticNumber.value == number.value)
                {
                    number.Delete();
                    staticNumber.Increase(1);
                    EndDrag();
                    Points.instance.Increase();
                }
            }
        }

        public void EndDrag() {
            transform.localPosition = pos;
            number.isMoving = false;
        }
    }
}
