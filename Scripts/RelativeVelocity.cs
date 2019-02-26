using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(RelativeVelocity))]
    [RequireComponent(typeof(Rigidbody))]
    public class RelativeVelocity : MonoBehaviour
    {
#pragma warning disable IDE0044 // Add readonly modifier
        [SerializeField] Vector3 _amount = Vector3.forward;
        [SerializeField] bool _stopOnDisable = true;
#pragma warning restore IDE0044 // Add readonly modifier

        void OnEnable() => GetComponent<Rigidbody>().AddRelativeForce(_amount, ForceMode.VelocityChange);
        void OnDisable() { if (_stopOnDisable) GetComponent<Rigidbody>().velocity = Vector3.zero; }
    } 
}
