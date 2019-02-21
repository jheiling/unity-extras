using System;
using UnityEngine;
using UnityEditor;

namespace Extras
{
    public static class EditorGUILayoutExtras
    {
        public static void Horizontal(in Action inner, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal(options);
            inner();
            EditorGUILayout.EndHorizontal();
        }

        public static void Horizontal(in Action inner, in GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginHorizontal(style, options);
            inner();
            EditorGUILayout.EndHorizontal();
        }


        public static void Vertical(in Action inner, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(options);
            inner();
            EditorGUILayout.EndVertical();
        }

        public static void Vertical(in Action inner, in GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginVertical(style, options);
            inner();
            EditorGUILayout.EndVertical();
        }


        public static void ScrollView(in Action inner, in Vector2 scrollPosition, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(in Action inner, in Vector2 scrollPosition, in GUIStyle style, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, style, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(in Action inner, in Vector2 scrollPosition, in bool alwaysShowHorizontal, in bool alwaysShowVertical, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(in Action inner, in Vector2 scrollPosition, 
            in GUIStyle horizontalScrollbar, in GUIStyle verticalScrollbar, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, options);
            inner();
            EditorGUILayout.EndScrollView();
        }

        public static void ScrollView(in Action inner, in Vector2 scrollPosition, in bool alwaysShowHorizontal, in bool alwaysShowVertical,
            in GUIStyle horizontalScrollbar, in GUIStyle verticalScrollbar, in GUIStyle background, params GUILayoutOption[] options)
        {
            EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, options);
            inner();
            EditorGUILayout.EndScrollView();
        }


        public static Quaternion QuaternionField(in GUIContent label, in Quaternion value, params GUILayoutOption[] options) => 
            EditorGUILayout.Vector4Field(label, value.ToVector4(), options).ToQuaternion();

        public static Quaternion QuaternionField(in string label, in Quaternion value, params GUILayoutOption[] options) =>
            QuaternionField(new GUIContent(label), value, options);
    }
}
