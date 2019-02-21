using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(CollisionSelfDestruct))]
    [RequireComponent(typeof(Collider))]
    public class CollisionSelfDestruct : MonoBehaviour
    {
        void OnCollisionEnter() { if (enabled) Destroy(gameObject); }
    } 
}
