using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using CellsDragNDrop;
using System.Collections;

namespace CellsDragNDrop
{
    public class Spawner : MonoBehaviour
    {
        public Cell[] cells;
        public List<Cell> cellsEmpty = new List<Cell>();
        float timer = 10.0f;

        void Start()
        {
            cells = GameObject.Find("cells").GetComponentsInChildren<Cell>();
            cellsEmpty = cells.OfType<Cell>().ToList();
            Spawn();
        }

        void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f) { Spawn(); timer = 10.0f; }
        }

        void Spawn()
        {
            if (cellsEmpty.Count>0)
            {
                int rand = (int)Random.Range(0, cellsEmpty.Count);
                cellsEmpty[rand].text.text = 1.ToString();
                cellsEmpty.RemoveAt(rand);
            }
        }
    }
}
