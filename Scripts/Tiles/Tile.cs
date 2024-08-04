using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private GameObject highlight;
    [SerializeField] private bool isPlaceable;
    public BaseBuilding occupiedUnit;
    public bool walkable => isPlaceable && occupiedUnit == null;

    private void OnMouseDown()
    {
        
    }

    public void Init(bool isOffset)
    {
        renderer.color = isOffset ? offsetColor : baseColor;
    }

    private void OnMouseEnter()
    {
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        highlight.SetActive(false);
    }

    public void SetBuilding(BaseBuilding building)
    {
        if (building.occupiedTile != null) building.occupiedTile.occupiedUnit = null;
        
        //If something gets spawned on this tile it nothing else can spawn there
        building.transform.position = transform.position;
        occupiedUnit = building;
        building.occupiedTile = this;
    }
}
