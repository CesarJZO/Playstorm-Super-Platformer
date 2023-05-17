using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameOverTrigger trigger;

    private void Start()
    {
        trigger.GameOver += OnGameOver;

        gameObject.SetActive(false);
    }

    private void OnGameOver()
    {
        gameObject.SetActive(true);
    }
}
