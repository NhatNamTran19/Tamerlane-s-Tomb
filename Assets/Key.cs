using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameManager3d _gameManager;
    [SerializeField] DoorOpen _doorOpen;

    private void Update()
    {
        if(_gameManager._silverKey)
        {
            _doorOpen.enabled = true;
        }
    }


}
