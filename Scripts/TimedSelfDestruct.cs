using System.Collections;
using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(TimedSelfDestruct))]
    public class TimedSelfDestruct : MonoBehaviour
    {
#pragma warning disable IDE0044 // Add readonly modifier
        [SerializeField, Min(0)] float _time = 10;
#pragma warning restore IDE0044 // Add readonly modifier

        IEnumerator Start()
        {
            yield return new WaitForSeconds(_time);
            Destroy(gameObject);
        }
    } 
}
