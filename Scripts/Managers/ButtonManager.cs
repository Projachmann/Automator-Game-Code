using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public List<GameObject> buildings = new List<GameObject>();
    public GameObject selectedBuilding;

    public GameObject GetGameObjectByName(string name)
    {
        foreach (var item in buildings)
        {
            if (item.name == name)
            {
                return item.gameObject;
            }
        }
        return null;
    }

    public void Extractor()
    {
        selectedBuilding = GetGameObjectByName("Extractor");
    }
}
