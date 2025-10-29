using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using Ebac.Core.Singleton;

public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject playerPrefab;

    [Header("Enemies")]
    public List<GameObject> enemiesList;

    [Header("Reference")]
    public Transform startPosition;

    [Header("Animations")]
    public float duration = .2f;
    public float delay = .05f;
    public Ease ease = Ease.OutBack;

    private GameObject _currentPlayer;


    private void Start()
    {
        Init();
    }

    public void Init()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        _currentPlayer = Instantiate(playerPrefab);
        _currentPlayer.transform.position = startPosition.position;
        _currentPlayer.transform.DOScale(0, duration).From().SetEase(ease).SetDelay(delay);
    }
}
