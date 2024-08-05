using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private GameObject highlight;
    [SerializeField] private bool isPlaceable = true;
    [SerializeField] private ButtonManager buttonManager;

    private void Start()
    {
        buttonManager = GameObject.Find("ButtonManager").GetComponent<ButtonManager>();
    }

    private void OnMouseDown()
    {
        if (isPlaceable && buttonManager.selectedBuilding != null)
        {
            isPlaceable = false;
            Instantiate(buttonManager.selectedBuilding, buttonManager.selectedBuilding.transform.position = gameObject.transform.position, Quaternion.identity);
            buttonManager.selectedBuilding = null;
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
}
