using UnityEngine;
using UnityExtensions.Math;

namespace UnityExtensions.Physics
{
    public static partial class PhysicsExtensions
    {
        #region Box

        public static bool BoxCast(BoxCollider box, Vector3 direction, float maxDistance = Mathf.Infinity,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            return UnityEngine.Physics.BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static bool BoxCast(BoxCollider box, Vector3 direction, out RaycastHit hitInfo,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            return UnityEngine.Physics.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance,
                layerMask,
                queryTriggerInteraction);
        }

        public static RaycastHit[] BoxCastAll(BoxCollider box, Vector3 direction, float maxDistance = Mathf.Infinity,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            // ReSharper disable once Unity.PreferNonAllocApi
            return UnityEngine.Physics.BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static int BoxCastNonAlloc(BoxCollider box, Vector3 direction, RaycastHit[] results,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            return UnityEngine.Physics.BoxCastNonAlloc(center, halfExtents, direction, results, orientation,
                maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static bool CheckBox(BoxCollider box, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            return UnityEngine.Physics.CheckBox(center, halfExtents, orientation, layerMask, queryTriggerInteraction);
        }

        public static Collider[] OverlapBox(BoxCollider box, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            // ReSharper disable once Unity.PreferNonAllocApi
            return UnityEngine.Physics.OverlapBox(center, halfExtents, orientation, layerMask, queryTriggerInteraction);
        }

        public static int OverlapBoxNonAlloc(BoxCollider box, Collider[] results,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            box.ToWorldSpaceBox(out Vector3 center, out Vector3 halfExtents, out Quaternion orientation);
            return UnityEngine.Physics.OverlapBoxNonAlloc(center, halfExtents, results, orientation, layerMask,
                queryTriggerInteraction);
        }

        #endregion

        #region Sphere

        public static bool SphereCast(SphereCollider sphere, Vector3 direction, out RaycastHit hitInfo,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            sphere.ToWorldSpaceSphere(out Vector3 center, out float radius);
            return UnityEngine.Physics.SphereCast(center, radius, direction, out hitInfo, maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static RaycastHit[] SphereCastAll(SphereCollider sphere, Vector3 direction,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            sphere.ToWorldSpaceSphere(out Vector3 center, out float radius);
            // ReSharper disable once Unity.PreferNonAllocApi
            return UnityEngine.Physics.SphereCastAll(center, radius, direction, maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static int SphereCastNonAlloc(SphereCollider sphere, Vector3 direction, RaycastHit[] results,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            sphere.ToWorldSpaceSphere(out Vector3 center, out float radius);
            return UnityEngine.Physics.SphereCastNonAlloc(center, radius, direction, results, maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static bool CheckSphere(SphereCollider sphere, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            sphere.ToWorldSpaceSphere(out Vector3 center, out float radius);
            return UnityEngine.Physics.CheckSphere(center, radius, layerMask, queryTriggerInteraction);
        }

        public static Collider[] OverlapSphere(SphereCollider sphere,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            sphere.ToWorldSpaceSphere(out Vector3 center, out float radius);
            // ReSharper disable once Unity.PreferNonAllocApi
            return UnityEngine.Physics.OverlapSphere(center, radius, layerMask, queryTriggerInteraction);
        }

        public static int OverlapSphereNonAlloc(SphereCollider sphere, Collider[] results,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            sphere.ToWorldSpaceSphere(out Vector3 center, out float radius);
            return UnityEngine.Physics.OverlapSphereNonAlloc(center, radius, results, layerMask,
                queryTriggerInteraction);
        }

        #endregion

        #region Capsule

        public static bool CapsuleCast(CapsuleCollider capsule, Vector3 direction, out RaycastHit hitInfo,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            capsule.ToWorldSpaceCapsule(out Vector3 point0, out Vector3 point1, out float radius);
            return UnityEngine.Physics.CapsuleCast(point0, point1, radius, direction, out hitInfo, maxDistance,
                layerMask,
                queryTriggerInteraction);
        }

        public static RaycastHit[] CapsuleCastAll(CapsuleCollider capsule, Vector3 direction,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            capsule.ToWorldSpaceCapsule(out Vector3 point0, out Vector3 point1, out float radius);
            // ReSharper disable once Unity.PreferNonAllocApi
            return UnityEngine.Physics.CapsuleCastAll(point0, point1, radius, direction, maxDistance, layerMask,
                queryTriggerInteraction);
        }

        public static int CapsuleCastNonAlloc(CapsuleCollider capsule, Vector3 direction, RaycastHit[] results,
            float maxDistance = Mathf.Infinity, int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            capsule.ToWorldSpaceCapsule(out Vector3 point0, out Vector3 point1, out float radius);
            return UnityEngine.Physics.CapsuleCastNonAlloc(point0, point1, radius, direction, results, maxDistance,
                layerMask,
                queryTriggerInteraction);
        }

        public static bool CheckCapsule(CapsuleCollider capsule,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            capsule.ToWorldSpaceCapsule(out Vector3 point0, out Vector3 point1, out float radius);
            return UnityEngine.Physics.CheckCapsule(point0, point1, radius, layerMask, queryTriggerInteraction);
        }

        public static Collider[] OverlapCapsule(CapsuleCollider capsule,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            capsule.ToWorldSpaceCapsule(out Vector3 point0, out Vector3 point1, out float radius);
            // ReSharper disable once Unity.PreferNonAllocApi
            return UnityEngine.Physics.OverlapCapsule(point0, point1, radius, layerMask, queryTriggerInteraction);
        }

        public static int OverlapCapsuleNonAlloc(CapsuleCollider capsule, Collider[] results,
            int layerMask = UnityEngine.Physics.DefaultRaycastLayers,
            QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
        {
            capsule.ToWorldSpaceCapsule(out Vector3 point0, out Vector3 point1, out float radius);
            return UnityEngine.Physics.OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask,
                queryTriggerInteraction);
        }

        #endregion

        private static void ToWorldSpaceBox(this BoxCollider box, out Vector3 center, out Vector3 halfExtents,
            out Quaternion orientation)
        {
            Transform transform = box.transform;

            orientation = transform.rotation;
            center = box.transform.TransformPoint(box.center);

            Vector3 scale = transform.lossyScale.Abs();
            halfExtents = Vector3.Scale(scale, box.size) * 0.5f;
        }

        private static void ToWorldSpaceSphere(this SphereCollider sphere, out Vector3 center, out float radius)
        {
            Transform transform = sphere.transform;
            center = transform.TransformPoint(sphere.center);
            radius = sphere.radius * transform.lossyScale.Abs().MaxDimensionValue();
        }

        private static void ToWorldSpaceCapsule(this CapsuleCollider capsule, out Vector3 point0, out Vector3 point1,
            out float radius)
        {
            Vector3 center = capsule.transform.TransformPoint(capsule.center);
            radius = 0f;
            var height = 0f;
            Vector3 lossyScale = capsule.transform.lossyScale.Abs();
            Vector3 dir = Vector3.zero;

            switch (capsule.direction)
            {
                case 0: // x
                    radius = Mathf.Max(lossyScale.y, lossyScale.z) * capsule.radius;
                    height = lossyScale.x * capsule.height;
                    dir = capsule.transform.TransformDirection(Vector3.right);
                    break;
                case 1: // y
                    radius = Mathf.Max(lossyScale.x, lossyScale.z) * capsule.radius;
                    height = lossyScale.y * capsule.height;
                    dir = capsule.transform.TransformDirection(Vector3.up);
                    break;
                case 2: // z
                    radius = Mathf.Max(lossyScale.x, lossyScale.y) * capsule.radius;
                    height = lossyScale.z * capsule.height;
                    dir = capsule.transform.TransformDirection(Vector3.forward);
                    break;
            }

            if (height < radius * 2f)
            {
                dir = Vector3.zero;
            }

            point0 = center + dir * (height * 0.5f - radius);
            point1 = center - dir * (height * 0.5f - radius);
        }
    }
}