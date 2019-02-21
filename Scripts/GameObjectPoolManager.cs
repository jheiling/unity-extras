using UnityEngine;

namespace Extras
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(GameObjectPoolManager))]
    public class GameObjectPoolManager : MonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] GameObjectPool[] _clearOnDestroy;
#pragma warning restore 649

        void OnDestroy() { for (var i = 0; i < _clearOnDestroy.Length; i++) _clearOnDestroy[i].Clear(); }
    } 
}
