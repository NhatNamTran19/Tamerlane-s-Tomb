using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmoText : MonoBehaviour
{
    [SerializeField] private TMP_Text _ammoText;
    [SerializeField] private Ammo _ammo;

    private int _lastValue;
    private int _lastValue2;

    private void Update()
    {
        if (_ammo.LoadedAmmo != _lastValue)
        {
            UpdateAmmoText();
            _lastValue = _ammo.LoadedAmmo;
        }
        if (_ammo.MaxMagazine != _lastValue2)
        {
            UpdateAmmoText();
            _lastValue2 = _ammo.MaxMagazine;
        }
    }
    private void UpdateAmmoText()
    {
        _ammoText.text = $"{_ammo.LoadedAmmo} / {_ammo.MaxMagazine}";
    }
}
