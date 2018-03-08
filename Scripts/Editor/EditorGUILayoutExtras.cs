using System;
using UnityEditor;



namespace Extras
{
    public static class EditorGUILayoutExtras
    {
        public static void Horizontal(Action inner)
        {
            EditorGUILayout.BeginHorizontal();
            inner();
            EditorGUILayout.EndHorizontal();
        }

        public static void Vertical(Action inner)
        {
            EditorGUILayout.BeginVertical();
            inner();
            EditorGUILayout.EndVertical();
        }
    }
}
