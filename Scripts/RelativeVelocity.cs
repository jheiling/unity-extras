using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(RelativeVelocity))]
    [RequireComponent(typeof(Rigidbody))]
    public class RelativeVelocity : MonoBehaviour
    {
        [SerializeField] Vector3 _amount = Vector3.forward;

        void Start() => GetComponent<Rigidbody>().AddRelativeForce(_amount, ForceMode.VelocityChange);
    } 
}
