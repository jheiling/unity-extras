using System.Collections;
using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(TimedSelfDestruct))]
    public class TimedSelfDestruct : MonoBehaviour
    {
#pragma warning disable 649, IDE0044 // Add readonly modifier
        [SerializeField, Min(0)] float _time = 10;
        [SerializeField] GameObjectPool _pool;
#pragma warning restore 649, IDE0044 // Add readonly modifier 

        void OnEnable() => StartCoroutine(DelayedDestroy());

        IEnumerator DelayedDestroy()
        {
            yield return new WaitForSeconds(_time);
            if (_pool) _pool.ReturnInstance(gameObject);
            else Destroy(gameObject);
        }
    } 
}
