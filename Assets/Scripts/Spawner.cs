using UnityEngine;
using System.Collections.Generic;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Spawner : MonoBehaviour
    {
        public static Spawner instance;
        public Cell[] cells;
        public List<Cell> cellsEmpty = new List<Cell>();
        const float period = 10f;
        float timer = 0;

        void Start()
        {
            instance = this;
            //cellsEmpty = cells.OfType<Cell>().ToList(); // GridLayout does it automatically
        }

        void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                if (cellsEmpty.Count > 0)
                {
                    int newValue = (cellsEmpty.Count >= 9) ? 1 : (int)Random.Range(1, Number.maxValue + 1);
                    Spawn(newValue);
                }
                timer = period;
            }
        }

        public void Spawn(int newValue)
        {
            int randCell = (int)Random.Range(0, cellsEmpty.Count);
            cellsEmpty[randCell].SetNumber(newValue);
            cellsEmpty.RemoveAt(randCell);
        }
    }
}
