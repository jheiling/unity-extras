using UnityEngine;

namespace Extras.UI
{
    [AddComponentMenu(nameof(Extras) + "/" + nameof(UI) + "/" + nameof(StatusBar))]
    [RequireComponent(typeof(RectTransform))]
    public class StatusBar : MonoBehaviour
    {
        [SerializeField] float _current = 100;
        [SerializeField] float _maximum = 100;

        public float Current
        {
            get => _current;
            set
            {
                _current = value;
                SetWidth();
            }
        }

        public float Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                SetWidth();
            }
        }

        void SetWidth()
        {
            var maximumWidth = transform.parent.GetComponent<RectTransform>().rect.width;
            GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _maximum == 0 ? 0 : _current / _maximum * maximumWidth);
        }
    } 
}
