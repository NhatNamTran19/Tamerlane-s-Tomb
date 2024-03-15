using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    [SerializeField] private GameObject[] _itemPrefab;
    [SerializeField] private GameManager3d _gameManager;
    [Range(0, 1)]
    [SerializeField] private float _accurracy = 1;

    public void Drop()
    {
        int item = Random.Range(0, 3);
        //Instantiate(_itemPrefab[0], transform.position+ new Vector3(0f,1.5f,0f), transform.rotation);
        print(item);
        float randomValue = Random.Range(0f, 1f);
        bool isMissed = (randomValue > _accurracy);
        if (isMissed) return;
        if (!isMissed)
        {
            Instantiate(_itemPrefab[item], transform.position + new Vector3(0f, 2f, 0f), transform.rotation);         
        }
        //if (_gameManager._quantityZombieDead == 2)
        //{
        //    Instantiate(_itemPrefab[0], transform.position, transform.rotation);
        //}
        //if (_gameManager._quantityZombieDead == 5)
        //{
        //    Instantiate(_itemPrefab[1], transform.position, transform.rotation);
        //}
        //if (_gameManager._quantityZombieDead == 8)
        //{
        //    Instantiate(_itemPrefab[2], transform.position, transform.rotation);
        //} 
        //if (_gameManager._quantityZombieDead == 15)
        //{
        //    Instantiate(_itemPrefab[3], transform.position, transform.rotation);
        //}
        //if (_gameManager._quantityZombieDead == 25)
        //{
        //    Instantiate(_itemPrefab[4], transform.position, transform.rotation);
        //}
    }

}
