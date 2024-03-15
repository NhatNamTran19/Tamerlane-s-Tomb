using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSwicher : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _rigids;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _aimingCamera;
    [SerializeField] private Transform _player;



    [ContextMenu("Collect bones")]
    private void CollectBones()
    {
        _rigids = GetComponentsInChildren<Rigidbody>();
    }

    [ContextMenu("Enable ragdoll")]
    public void EnableRagdoll() => SetRagdoll(true);

    [ContextMenu("Disable ragdoll")]
    public void DisableRagdoll() => SetRagdoll(false);
    private void SetRagdoll(bool isEnable)
    {
        foreach(var rigid in _rigids)
        {
            rigid.isKinematic = !isEnable;
        }
        _animator.enabled = !isEnable;
    }
    public void KnockBack()
    {
        foreach (var rigid in _rigids)
        {
            //rigid.AddExplosionForce(20f, this.transform.position, 10f, 5f, ForceMode.Impulse);
            Shooting _shooting = _player.GetComponentInChildren<Shooting>();
            Vector3 force = _aimingCamera.forward * _shooting._pushBackForce;
            rigid.AddForce(force, ForceMode.Impulse);
        }
    }
}
