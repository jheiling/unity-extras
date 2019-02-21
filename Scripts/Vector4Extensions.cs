using UnityEngine;

namespace Extras
{
    public static class Vector4Extensions
    {
        public static Quaternion ToQuaternion(this in Vector4 vector) => new Quaternion(vector.x, vector.y, vector.z, vector.w);
    }
}
