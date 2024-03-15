using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Ammo : MonoBehaviour
{
    [SerializeField] public int MagazineSize;
    [SerializeField] public int MaxMagazine;
    [SerializeField] private Shooting _shooting;
    [SerializeField] private InputActionReference _reloadAction;
    [SerializeField] private Animator _animPlayer;
    [SerializeField] private RigBuilder _rigBuilder;
    [SerializeField] private PlayerMovement _playerMovement;

    public UnityEvent StartReload; 
    public UnityEvent DoneReload;
    private int _emptyMagazineSize;
    public int LoadedAmmo { get; set; }
    public bool _doReload;
    void Start()
    {
        //ReFillAmmo();
        LoadedAmmo = MagazineSize;
    }

    // Update is called once per frame
    void Update()
    {
        _emptyMagazineSize = MagazineSize - LoadedAmmo;
        if (_reloadAction.action.triggered && _emptyMagazineSize !=0 && !_doReload && MaxMagazine !=0)
        {
            StarReload();
            _shooting._shoot.Stop();         
            //if (_emptyMagazineSize < MaxMagazine) 
            //{ 
            //MaxMagazine -= _emptyMagazineSize;
            //}
            //if (_emptyMagazineSize > MaxMagazine)
            //{
            //    MaxMagazine = 0;
            //}
        }
        _rigBuilder.layers[2].active = false;
    }

    private void StarReload()
    {
        _doReload = true;
        if (MaxMagazine > 0)
        {
            StartReload.Invoke();
            //_playerMovement.enabled = false;
            _animPlayer.SetBool("Reloading",_doReload);
            _animPlayer.SetTrigger("DoReload");
            // _animGun.SetTrigger("DoReload");
            _shooting.Lock();
            //_automaticRifle._shootEffect.Stop();
           
        }
        else
            return;
    }

    protected virtual void ReFillAmmo()
    {
        if (MaxMagazine > MagazineSize)
        {
            LoadedAmmo = MagazineSize;
        }
        //if (MaxMagazine == MagazineSize)
        //{
        //    if (_emptyMagazineSize < MaxMagazine)
        //    {
        //        LoadedAmmo = MagazineSize;
        //    }
        //    if (_emptyMagazineSize > MaxMagazine)
        //    {
        //        LoadedAmmo = MaxMagazine;
        //        MaxMagazine = 0;
        //    }
        //}
        if (MaxMagazine <= MagazineSize)
        {
            if(_emptyMagazineSize <= MaxMagazine)
            {
                LoadedAmmo = MagazineSize;
            }
            if(_emptyMagazineSize > MaxMagazine)
            {
                LoadedAmmo = MaxMagazine;
                //MaxMagazine = 0;
            }
        }
    }

    public void DecreaseAmmo()
    {
        LoadedAmmo--;
        if (LoadedAmmo <= 0 && MaxMagazine > 0)
        {
            StartCoroutine(SniperReLoad());
        }
    }
    private IEnumerator SniperReLoad()
    {
        StartReload.Invoke();
        yield return new WaitForSeconds(0.1f);
        StarReload();
        
    }

    public void Reload()
    {
        _animPlayer.SetTrigger("DoReload");
        //_animGun.SetTrigger("DoReload");
        if (LoadedAmmo > 0)
        {
            _shooting.Unlock();
        }
    }

    public void Reload_Completed()
    {
        DoneReload.Invoke();
        //_playerMovement.enabled = true;
        if (!gameObject.activeInHierarchy) return;
        ReFillAmmo();
        if (_emptyMagazineSize <= MaxMagazine)
        {
            MaxMagazine -= _emptyMagazineSize;
        }
        if (_emptyMagazineSize > MaxMagazine)
        {
            MaxMagazine = 0;
        }
        _shooting.Unlock();

        //if (LoadedAmmo > 0)
        //{
        //}
        _doReload = false;
        _animPlayer.SetBool("Reloading", _doReload);
        //_animPlayer.ResetTrigger("DoReload");
    }
    public void PickMagazine()
    {
        MaxMagazine += MagazineSize;
    }
}
