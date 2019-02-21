using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(CollisionSelfDestruct))]
    [RequireComponent(typeof(Collider))]
    public class CollisionSelfDestruct : MonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] GameObjectPool _pool;
#pragma warning restore 649

        void OnCollisionEnter()
        {
            if (enabled)
            {
                if (_pool) _pool.ReturnInstance(gameObject);
                else Destroy(gameObject);
            }
        }
    } 
}
