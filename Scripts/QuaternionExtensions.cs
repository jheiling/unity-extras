using UnityEngine;

namespace Extras
{
    public static class QuaternionExtensions
    {
        public static Vector4 ToVector4(this in Quaternion quaternion) => new Vector4(quaternion.x, quaternion.y, quaternion.z, quaternion.w);
    }
}
