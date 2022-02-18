using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public static GamePhase CurrentGamePhase;
    public static Transform DefaultParent;

    [SerializeField] ShootingAI _shootingAI;
    [SerializeField] Containers _containers;
    [SerializeField] Transform _defaultParent;
    [SerializeField] DummyHandler _dummyHandler;

    // Start is called before the first frame update
    void Awake()
    {
        CurrentGamePhase = GamePhase.Start;
        DefaultParent = _defaultParent;
        _containers.Init();
        _dummyHandler.Init();
        _shootingAI.AwakeShooterAI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TranslateToNextPhase();
        }
    } 

    public void TranslateToNextPhase()
    {
        if (CurrentGamePhase == GamePhase.Start)
        {
            CurrentGamePhase = GamePhase.Fighting;
        }
        if (CurrentGamePhase == GamePhase.Fighting)
        {
            CurrentGamePhase = GamePhase.Start;
        }
    }
}
