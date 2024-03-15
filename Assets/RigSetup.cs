using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RigSetup : MonoBehaviour
{
    [SerializeField] private RigBuilder _rigBuilder;

    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private AutoRifle _autoRifle;

    private void Update()
    {

    }

    public void Lock()
    {
        _playerMovement.Lock();
        _rigBuilder.layers[1].active = false;
        _rigBuilder.layers[2].active = false;
        _autoRifle.StopFire();
    }
    public void Unlock()
    {
        _playerMovement.Unlock();
    }
}
