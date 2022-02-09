using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

[UnityEngine.CreateAssetMenu(fileName = "Feagure", menuName = "Items/Feagure", order = 0)]
public class Feagure : UnityEngine.ScriptableObject
{
    [SerializeField] private GameObject gameObj;
    [SerializeField] private string[] positions;
    [SerializeField] private FMoves move;
    [SerializeField] private string color;

    public string[] Positions => positions;
    public GameObject GameObj => gameObj;
    public FMoves Move => move;

    public string Color => color;
}