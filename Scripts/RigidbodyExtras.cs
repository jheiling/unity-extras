using UnityEngine;



namespace Extras
{
    /// <summary>
    /// Allows you to serialize additional Rigidbody properties.
    /// </summary>
    [AddComponentMenu("Extras/RigidbodyExtras")]
    [RequireComponent(typeof(Rigidbody))]
    public class RigidbodyExtras : MonoBehaviour
    {
        [SerializeField] Vector3 _velocity;
        [SerializeField] float _maxDepenetrationVelocity = Mathf.Infinity;
        [SerializeField] Vector3 _angularVelocity;
        [SerializeField] float _maxAngularVelocity = 7;
        [SerializeField] float _sleepThreshold = .005f;
        [SerializeField] bool _detectCollisions = true;
        [SerializeField] bool _setCentreOfMass;
        [SerializeField] Vector3 _centreOfMass;
        [SerializeField] bool _setInertiaTensor;
        [SerializeField] Vector3 _inertaTensor = new Vector3(.1666667f, .1666667f, .1666667f);
        [SerializeField] bool _setSolverIterations;
        [SerializeField] int _solverIterations = 6;
        [SerializeField] bool _setSolverVelocityIterations;
        [SerializeField] int _solverVelocityIterations = 1;
        Rigidbody _rigidbody;

        public Vector3 Velocity
        {
            get
            {
                return Application.isPlaying ? _rigidbody.velocity : _velocity;
            }

            set
            {
                if (Application.isPlaying) _rigidbody.velocity = value;
                else _velocity = value;
            }
        }

        public float MaxDepenetrationVelocity
        {
            get
            {
                return Application.isPlaying ? _rigidbody.maxDepenetrationVelocity : _maxDepenetrationVelocity;
            }

            set
            {
                if (Application.isPlaying) _rigidbody.maxDepenetrationVelocity = value;
                else _maxDepenetrationVelocity = value;
            }
        }

        public Vector3 AngularVelocity
        {
            get
            {
                return Application.isPlaying ? _rigidbody.angularVelocity : _angularVelocity;
            }

            set
            {
                if (Application.isPlaying) _rigidbody.angularVelocity = value;
                else _angularVelocity = value;
            }
        }

        public float MaxAngularVelocity
        {
            get
            {
                return Application.isPlaying ? _rigidbody.maxAngularVelocity : _maxAngularVelocity;
            }

            set
            {
                if (value >= 0)
                {
                    if (Application.isPlaying) _rigidbody.maxAngularVelocity = value;
                    else _maxAngularVelocity = value;
                }
            }
        }

        public float SleepThreshold
        {
            get
            {
                return Application.isPlaying ? _rigidbody.sleepThreshold : _sleepThreshold;
            }

            set
            {
                if (Application.isPlaying) _rigidbody.sleepThreshold = value;
                else _sleepThreshold = value;
            }
        }

        public bool DetectCollisions
        {
            get
            {
                return Application.isPlaying ? _rigidbody.detectCollisions : _detectCollisions;
            }

            set
            {
                if (Application.isPlaying) _rigidbody.detectCollisions = value;
                else _detectCollisions = value;
            }
        }

        public bool SetCentreOfMass
        {
            get
            {
                return _setCentreOfMass;
            }

            set
            {
                _setCentreOfMass = value;
            }
        }

        public Vector3 CentreOfMass
        {
            get
            {
                return Application.isPlaying ? _rigidbody.centerOfMass : _centreOfMass;
            }

            set
            {
                if (Application.isPlaying) _rigidbody.centerOfMass = value;
                else _centreOfMass = value;
            }
        }

        public bool SetInertiaTensor
        {
            get
            {
                return _setInertiaTensor;
            }

            set
            {
                _setInertiaTensor = value;
            }
        }

        public Vector3 InertiaTensor
        {
            get
            {
                return Application.isPlaying ? _rigidbody.inertiaTensor : _inertaTensor;
            }

            set
            {
                if (value.x > 0f && value.y > 0f && value.z > 0f)
                {
                    if (Application.isPlaying) _rigidbody.inertiaTensor = value;
                    else _inertaTensor = value;
                }
            }
        }

        public bool SetSolverIterations
        {
            get
            {
                return _setSolverIterations;
            }

            set
            {
                _setSolverIterations = value;
            }
        }

        public int SolverIterations
        {
            get
            {
                return Application.isPlaying ? _rigidbody.solverIterations : _solverIterations;
            }

            set
            {
                if (value > 0)
                {
                    if (Application.isPlaying) _rigidbody.solverIterations = value;
                    else _solverIterations = value;
                }
            }
        }

        public bool SetSolverVelocityIterations
        {
            get
            {
                return _setSolverVelocityIterations;
            }

            set
            {
                _setSolverVelocityIterations = value;
            }
        }

        public int SolverVelocityIterations
        {
            get
            {
                return Application.isPlaying ? _rigidbody.solverVelocityIterations : _solverVelocityIterations;
            }

            set
            {
                if (value > 0)
                {
                    if (Application.isPlaying) _rigidbody.solverVelocityIterations = value;
                    else _solverVelocityIterations = value;
                }
            }
        }

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.velocity = _velocity;
            _rigidbody.maxDepenetrationVelocity = _maxDepenetrationVelocity;
            _rigidbody.angularVelocity = _angularVelocity;
            _rigidbody.maxAngularVelocity = _maxAngularVelocity;
            _rigidbody.sleepThreshold = _sleepThreshold;
            _rigidbody.detectCollisions = _detectCollisions;
            if (_setCentreOfMass) _rigidbody.centerOfMass = _centreOfMass;
            if (_setInertiaTensor) _rigidbody.inertiaTensor = _inertaTensor;
            if (_setSolverIterations) _rigidbody.solverIterations = _solverIterations;
            if (_setSolverVelocityIterations) _rigidbody.solverVelocityIterations = _solverVelocityIterations;
        }
    }
}
