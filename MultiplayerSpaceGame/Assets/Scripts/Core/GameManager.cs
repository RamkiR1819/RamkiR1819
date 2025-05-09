using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private List<Player> players;
    private GameState currentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            players = new List<Player>();
            currentState = GameState.MainMenu;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Initialize game settings and load the main menu
        LoadMainMenu();
    }

    public void StartGame()
    {
        currentState = GameState.Playing;
        // Logic to start the game
    }

    public void EndGame()
    {
        currentState = GameState.GameOver;
        // Logic to end the game
    }

    public void AddPlayer(Player player)
    {
        players.Add(player);
        // Logic to handle new player connections
    }

    public void RemovePlayer(Player player)
    {
        players.Remove(player);
        // Logic to handle player disconnections
    }

    private void LoadMainMenu()
    {
        // Logic to load the main menu scene
    }

    private enum GameState
    {
        MainMenu,
        Playing,
        GameOver
    }
}