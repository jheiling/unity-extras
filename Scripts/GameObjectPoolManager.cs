using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(GameObjectPoolManager))]
    public class GameObjectPoolManager : MonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] GameObjectPool[] _clearOnEnable;
        [SerializeField] GameObjectPool[] _clearOnDisable;
#pragma warning restore 649

        void OnEnable() { for (var i = 0; i < _clearOnEnable.Length; i++) _clearOnEnable[i].Clear(); }
        void OnDisable() { for (var i = 0; i < _clearOnDisable.Length; i++) _clearOnDisable[i].Clear(); }
    } 
}
