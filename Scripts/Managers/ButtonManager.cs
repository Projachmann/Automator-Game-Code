using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ExtractorButton()
    {
        BuildingManager.Instance.SetSelectedBuilding(Extractor);
    }
}
