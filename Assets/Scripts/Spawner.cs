using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using CellsDragNDrop;
using System.Collections;

namespace CellsDragNDrop
{
    public class Spawner : MonoBehaviour
    {
        public static Spawner instance;
        public Cell[] cells;
        public static List<Cell> emptyCells = new List<Cell>();
        //public  List<Cell> emptyCells2 = new List<Cell>();
        const float period = 1f;
        float timer = period;


        void Start()
        {
            instance = this;
            //cells = GetComponentsInChildren<Cell>();
            emptyCells = cells.OfType<Cell>().ToList();
            //Debug.LogError(cells.Length);
            //Debug.LogError(emptyCells.Count);
            Debug.Log("emptyCells len1="+ emptyCells.Count);
        }

        void Update()
        {
            //timer -= Time.deltaTime;
            //if (timer <= 0.0f) 
            //{
            //    if (emptyCells.Count > 0)
            //    {
            //        int newValue = (emptyCells.Count >= 9) ? 1 : (int)Random.Range(1, Number.maxValue + 1);
            //        Spawn(newValue);
            //    }
            //    timer = period;
            //}
            Debug.Log("emptyCells len="+ emptyCells.Count);
            //emptyCells2 = emptyCells;
        }

        public void Spawn(int newValue)
        {
            int randCell = (int)Random.Range(0, emptyCells.Count);
            emptyCells[randCell].SetNumber(newValue);
            emptyCells.RemoveAt(randCell);
        }

    }
}
