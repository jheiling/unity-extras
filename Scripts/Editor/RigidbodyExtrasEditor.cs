using UnityEngine;
using UnityEditor;



namespace Extras
{
    [CustomEditor(typeof(RigidbodyExtras))]
    public class RigidbodyExtrasEditor : Editor
    {
        static readonly GUIContent _stopLabel = new GUIContent("Stop");
        static readonly GUIContent _resetLabel = new GUIContent("Reset");
        static readonly GUIContent _velocityLabel = new GUIContent("Velocity");
        static readonly GUIContent _maxDepenetrationVelocityLabel = new GUIContent("Max Depenetration Velocity");
        static readonly GUIContent _angularVelocityLabel = new GUIContent("Angular Velocity");
        static readonly GUIContent _maxAngularVelocityLabel = new GUIContent("Max Angular Velocity");
        static readonly GUIContent _sleepThresholdLabel = new GUIContent("Sleep Threshold");
        static readonly GUIContent _detectCollisionsLabel = new GUIContent("Detect Collisions");
        static readonly GUIContent _setCentreOfMassLabel = new GUIContent("Set Centre Of Mass");
        static readonly GUIContent _centreOfMassLabel = new GUIContent("Centre Of Mass");
        static readonly GUIContent _setInertiaTensorLabel = new GUIContent("Set Inertia Tensor");
        static readonly GUIContent _inertiaTensorLabel = new GUIContent("Inertia Tensor");
        static readonly GUIContent _setSolverIterationsLabel = new GUIContent("Set Solver Iterations");
        static readonly GUIContent _solverIterationsLabel = new GUIContent("Solver Iterations");
        static readonly GUIContent _setSolverVelocityIterationsLabel = new GUIContent("Set Solver Velocity Iterations");
        static readonly GUIContent _solverVelocityIterationsLabel = new GUIContent("Solver Velocity Iterations");

        Rigidbody _rigidbody;
        RigidbodyExtras _rigidbodyExtras;

        void OnEnable()
        {
            _rigidbodyExtras = target as RigidbodyExtras;
            _rigidbody = _rigidbodyExtras.GetComponent<Rigidbody>();
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayoutExtras.Horizontal(() =>
            {
                _rigidbodyExtras.Velocity = EditorGUILayout.Vector3Field(_velocityLabel, _rigidbodyExtras.Velocity);
                if (Application.isPlaying && GUILayout.Button(_stopLabel)) _rigidbodyExtras.Velocity = Vector3.zero;
            });

            _rigidbodyExtras.MaxDepenetrationVelocity = EditorGUILayout.FloatField(_maxDepenetrationVelocityLabel, _rigidbodyExtras.MaxDepenetrationVelocity);

            EditorGUILayoutExtras.Horizontal(() =>
            {
                _rigidbodyExtras.AngularVelocity = EditorGUILayout.Vector3Field(_angularVelocityLabel, _rigidbodyExtras.AngularVelocity);
                if (Application.isPlaying && GUILayout.Button(_stopLabel)) _rigidbodyExtras.AngularVelocity = Vector3.zero;
            });

            _rigidbodyExtras.MaxAngularVelocity = EditorGUILayout.FloatField(_maxAngularVelocityLabel, _rigidbodyExtras.MaxAngularVelocity);

            _rigidbodyExtras.SleepThreshold = EditorGUILayout.FloatField(_sleepThresholdLabel, _rigidbodyExtras.SleepThreshold);

            _rigidbodyExtras.DetectCollisions = EditorGUILayout.Toggle(_detectCollisionsLabel, _rigidbodyExtras.DetectCollisions);

            if (!Application.isPlaying) _rigidbodyExtras.SetCentreOfMass = EditorGUILayout.Toggle(_setCentreOfMassLabel, _rigidbodyExtras.SetCentreOfMass);
            if (Application.isPlaying || _rigidbodyExtras.SetCentreOfMass)
            {
                EditorGUILayoutExtras.Horizontal(() =>
                {
                    _rigidbodyExtras.CentreOfMass = EditorGUILayout.Vector3Field(_centreOfMassLabel, _rigidbodyExtras.CentreOfMass);
                    if (Application.isPlaying && GUILayout.Button(_resetLabel)) _rigidbody.ResetCenterOfMass();
                });
            }

            if (!Application.isPlaying) _rigidbodyExtras.SetInertiaTensor = EditorGUILayout.Toggle(_setInertiaTensorLabel, _rigidbodyExtras.SetInertiaTensor);
            if (Application.isPlaying || _rigidbodyExtras.SetInertiaTensor)
            {
                EditorGUILayoutExtras.Horizontal(() =>
                {
                    _rigidbodyExtras.InertiaTensor = EditorGUILayout.Vector3Field(_inertiaTensorLabel, _rigidbodyExtras.InertiaTensor);
                    if (Application.isPlaying && GUILayout.Button(_resetLabel)) _rigidbody.ResetInertiaTensor();
                });
            }

            if (!Application.isPlaying) _rigidbodyExtras.SetSolverIterations = EditorGUILayout.Toggle(_setSolverIterationsLabel, _rigidbodyExtras.SetSolverIterations);
            if (Application.isPlaying || _rigidbodyExtras.SetSolverIterations)
            {
                EditorGUILayoutExtras.Horizontal(() =>
                {
                    _rigidbodyExtras.SolverIterations = EditorGUILayout.IntField(_solverIterationsLabel, _rigidbodyExtras.SolverIterations);
                    if (Application.isPlaying && GUILayout.Button(_resetLabel)) _rigidbody.solverIterations = Physics.defaultSolverIterations;
                });
            }

            if (!Application.isPlaying) _rigidbodyExtras.SetSolverVelocityIterations = EditorGUILayout.Toggle(_setSolverVelocityIterationsLabel, _rigidbodyExtras.SetSolverVelocityIterations);
            if (Application.isPlaying || _rigidbodyExtras.SetSolverVelocityIterations)
            {
                EditorGUILayoutExtras.Horizontal(() =>
                {
                    _rigidbodyExtras.SolverVelocityIterations = EditorGUILayout.IntField(_solverVelocityIterationsLabel, _rigidbodyExtras.SolverVelocityIterations);
                    if (Application.isPlaying && GUILayout.Button(_resetLabel)) _rigidbody.solverVelocityIterations = Physics.defaultSolverVelocityIterations;
                });
            }
        }

        public override bool RequiresConstantRepaint()
        {
            return true;
        }
    }
}
