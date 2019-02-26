using System.Collections.Generic;
using UnityEngine;

namespace Extras
{
    [CreateAssetMenu(menuName = nameof(Extras) + "/" + nameof(GameObjectPool))]
    public class GameObjectPool : ScriptableObject
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
        [SerializeField] GameObject _prefab;
        [SerializeField, Min(1)] int _maximumCount = 10;
#pragma warning restore 649, IDE0044 // Add readonly modifier
        Queue<GameObject> _pooled = new Queue<GameObject>();

        public GameObject GetInstance()
        {
            if (_pooled.Count > 0)
            {
                var instance = _pooled.Dequeue();
                instance.SetActive(true);
                return instance;
            }
            else return Instantiate(_prefab);
        }

        public GameObject GetInstance(in Vector3 position, in Quaternion rotation)
        {
            if (_pooled.Count > 0)
            {
                var instance = _pooled.Dequeue();
                instance.transform.position = position;
                instance.transform.rotation = rotation;
                instance.SetActive(true);
                return instance;
            }
            else return Instantiate(_prefab, position, rotation);
        }

        public void ReturnInstance(in GameObject instance)
        {
            if (_pooled.Count == _maximumCount) Destroy(instance);
            else
            {
                instance.SetActive(false);
                _pooled.Enqueue(instance);
            }
        }

        public void Clear() => _pooled.Clear();
    } 
}
