using UnityEngine;


[CreateAssetMenu(fileName = "Cell", menuName = "Item/Cell", order = 0)]
public class Cell : ScriptableObject
{
    [SerializeField] private GameObject cellPrefab;
    [SerializeField] private Vector3 position;
    public CellStatus status;

    public Vector3 Position => position;
    public GameObject CellPrefab => cellPrefab;
}