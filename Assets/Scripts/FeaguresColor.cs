using UnityEngine;


[CreateAssetMenu(fileName = "FColor", menuName = "Items/FColor", order = 0)]
public class FeaguresColor : ScriptableObject
{
    [SerializeField] private Feagure[] feagures;

    public Feagure[] Feagures => feagures;
}