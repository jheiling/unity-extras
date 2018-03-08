using System;
using UnityEngine;
using UnityEditor;



namespace Extras
{
    public static class EditorGUILayoutExtras
    {
        public static void Horizontal(Action inner, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal(options);
            inner();
            EditorGUILayout.EndHorizontal();
        }

        public static void Horizontal(Action inner, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal(style, options);
            inner();
            EditorGUILayout.EndHorizontal();
        }


        public static void Vertical(Action inner, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(options);
            inner();
            EditorGUILayout.EndVertical();
        }

        public static void Vertical(Action inner, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            inner();
            EditorGUILayout.EndVertical();
        }


        public static void ScrollView(Action inner, Vector2 scrollPosition, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(Action inner, Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, style, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(Action inner, Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(Action inner, Vector2 scrollPosition, 
            GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(Action inner, Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, 
            GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
            inner();
            EditorGUILayout.EndScrollView();
        }


        public static Quaternion QuaternionField(GUIContent label, Quaternion value, params GUILayoutOption[] options)
        {
            var vector = EditorGUILayout.Vector4Field(label, new Vector4(value.x, value.y, value.z, value.w), options);
            return new Quaternion(vector.x, vector.y, vector.z, vector.w);
        }

        public static Quaternion QuaternionField(string label, Quaternion value, params GUILayoutOption[] options)
        {
            return QuaternionField(new GUIContent(label), value, options);
        }
    }
}
