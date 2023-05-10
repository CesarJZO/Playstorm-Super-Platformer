using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameOverTrigger trigger;

    private void Start()
    {
        trigger.GameOver += OnGameOver;

        gameOverMenu.SetActive(false);
    }

    private void OnGameOver()
    {
        gameOverMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
