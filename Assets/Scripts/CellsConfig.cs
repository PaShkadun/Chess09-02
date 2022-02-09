using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Cells", menuName = "Items/Cells", order = 0)]
    public class CellsConfig : ScriptableObject
    {
        [SerializeField] private Cell[] cells;
        [SerializeField] private GameObject parent;
        private bool isParentFounded;

        public Cell[] Cells => cells;
        private Dictionary<string, Transform> cellPos = new Dictionary<string, Transform>();

        public bool FindParent()
        {
            parent = GameObject.FindWithTag("Board");

            if (parent is null)
            {
                return false;
            }
            
            Debug.Log("asd");

            return true;
        }
        
        public void TakeCells()
        {
            if (!isParentFounded)
            {
                isParentFounded = true;
                FindParent();
            }
            
            foreach (var cell in cells)
            {
                var c = Instantiate(cell.CellPrefab, new Vector3(cell.Position.x, cell.Position.y, cell.Position.z), Quaternion.Euler(0, -90, 90));
                c.transform.SetParent(parent.transform);
                c.name = cell.name;
                
                cellPos.Add(cell.name, c.transform);
            }
        }

        public void TakeFeagureByName(Feagure f, string color)
        {
            foreach (var fPosition in f.Positions)
            {
                if (color == "white")
                {
                    cells.FirstOrDefault(x => x.Position == cellPos[fPosition].position).status = CellStatus.White;
                }
                else if (color == "black")
                {
                    cells.FirstOrDefault(x => x.Position == cellPos[fPosition].position).status = CellStatus.Black;
                }
                
                var c = Instantiate(f.GameObj, cellPos[fPosition].position, Quaternion.Euler(0, -90, 90));
            }
        }
    }
}