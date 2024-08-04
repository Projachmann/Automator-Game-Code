using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance;

    private List<ScriptableBuilding> building;

    public void Awake()
    {
        Instance = this;

        building = Resources.LoadAll<ScriptableBuilding>("Buildings").ToList();
    }

    public void SpawnBuilding()
    {
        //var tile = Transform.postion of Mousclick
        //tile.SetBuilding(spawnedBuilding);
    }
}
