using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public static Tile Instance;
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private GameObject highlight;
    [SerializeField] private bool isPlaceable;
    public BaseBuilding occupiedBuilding;
    public bool walkable => isPlaceable && occupiedBuilding == null;

    public void Awake()
    {
        Instance = this;
    }
    private void OnMouseDown()
    {
        if (GameManager.Instance.state != GameState.PlaceBuildings) return;

        else if (occupiedBuilding != null)
        {
            BuildingManager.Instance.SetSelectedBuilding(occupiedBuilding);
        }
        else
        {
            Instantiate(BuildingManager.Instance.selectedBuilding);
            BuildingManager.Instance.SetSelectedBuilding(null);
        }
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
        if (building.occupiedTile != null) building.occupiedTile.occupiedBuilding = null;
        
        //If something gets spawned on this tile it nothing else can spawn there
        building.transform.position = transform.position;
        occupiedBuilding = building;
        building.occupiedTile = this;
    }
}
