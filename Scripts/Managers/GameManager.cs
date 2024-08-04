using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState state;
    public static event Action<GameState> OnGameStateChange;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.LoadGrid);
    }

    public void UpdateGameState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.LoadGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.PlaceBuildings:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnGameStateChange?.Invoke(newState);
    }
}

public enum GameState
{
    LoadGrid,
    PlaceBuildings
}