using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Building", menuName = "Scriptable Building")]
public class ScriptableBuilding : ScriptableObject
{
    public BaseBuilding buildingPrefab;
}
