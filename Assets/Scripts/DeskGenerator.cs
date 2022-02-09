using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEditor.UIElements;
using UnityEngine;


public class DeskGenerator : MonoBehaviour
{
    [SerializeField] private FeaguresColor[] feagures;
    [SerializeField] private GameObject[] cells;
    [SerializeField] private CellsConfig cellsConf;

    private void Start()
    {
        cellsConf.TakeCells();

        foreach (var feagure in feagures)
        {
            foreach (var f in feagure.Feagures)
            {
                cellsConf.TakeFeagureByName(f, f.Color);
            }
        }
    }
}