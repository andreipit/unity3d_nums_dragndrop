﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CellsDragNDrop;

namespace CellsDragNDrop
{ 
    public class DropHandler : MonoBehaviour
    {
        Number number;
        Cell cell;
        Vector3 pos;

        void Start()
        {
            pos = transform.localPosition;
            number = GetComponent<Number>();
            cell = transform.parent.GetComponent<Cell>();
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Number")
            {
                if (number.isMoving) // all calculations are only on moving number
                {
                    Number staticNumber = collision.GetComponent<Number>();
                    if (staticNumber.value == number.value)
                    {
                        number.Delete();
                        staticNumber.Increase(1);
                        Spawner.instance.cellsEmpty.Add(cell);
                        EndDrag();
                        Points.instance.Increase();
                    }
                }
            } 
            else if (collision.tag == "Recycle")
            {
                number.Delete();
                Spawner.instance.cellsEmpty.Add(cell);
                EndDrag();
            }
        }

        public void EndDrag() {
            transform.localPosition = pos;
            number.isMoving = false;
        }
    }
}
