using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Moves", menuName = "Items/Moves", order = 0)]
    public class FMoves : ScriptableObject
    {
        [SerializeField] private Vector3[] move;

        public Vector3[] Move => move;
    }
}