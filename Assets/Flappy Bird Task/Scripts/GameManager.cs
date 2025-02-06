using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState currentGameState = GameState.Pregame;
    public int score = 0;
    public Text scoreDisplay;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this && instance != this)
        {
            Destroy(this);
        }
    }
    public void UpdatingUI()
    {
        scoreDisplay.text = $"Score: {score}";
    }
}
public enum GameState
{
    Pregame,
    Game,
    PostGame
}