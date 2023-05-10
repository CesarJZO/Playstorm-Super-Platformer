using System;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public event Action GameOver;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameOver?.Invoke();
        }
    }
}
