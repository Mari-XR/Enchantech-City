using UnityEngine;
using static UnityEngine.RectTransform;

namespace UHFPS.Runtime
{
    public class AutoRotate : MonoBehaviour
    {
        public Vector3 RotateAxis;
        public float RotateSpeed;

        private Vector3 axis;

        private void Awake()
        {
            axis = transform.TransformDirection(RotateAxis);
        }

        private void Update()
        {
            transform.Rotate(RotateSpeed * Time.deltaTime * axis);
        }
    }
}