﻿using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private EnemyContainer _enemyContainer;

    private void OnEnable()
    {
        _enemyContainer.GameOvered += FinishGame;
    }

    private void FinishGame()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnDisable()
    {
        _enemyContainer.GameOvered -= FinishGame;
    }
}