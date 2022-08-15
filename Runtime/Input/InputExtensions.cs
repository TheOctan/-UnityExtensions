using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace UnityExtensions.Input
{
    public static partial class InputExtensions
    {
        private static readonly Camera _cachedMainCamera;

        /// <summary>
        /// Returns mouse position in world with Z = 0f
        /// </summary>
        /// <returns></returns>
        public static Vector3 GetMouseWorldPosition()
        {
            Vector3 position = GetMouseWorldPositionWithZ(UnityEngine.Input.mousePosition, Camera.main);
            position.z = 0f;
            return position;
        }

        /// <summary>
        /// Returns mouse position in world
        /// </summary>
        /// <returns></returns>
        public static Vector3 GetMouseWorldPositionWithZ()
        {
            return GetMouseWorldPositionWithZ(UnityEngine.Input.mousePosition, _cachedMainCamera);
        }

        /// <summary>
        /// Returns mouse position in world
        /// </summary>
        /// <param name="worldCamera"></param>
        /// <returns></returns>
        public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
        {
            return GetMouseWorldPositionWithZ(UnityEngine.Input.mousePosition, worldCamera);
        }

        /// <summary>
        /// Returns mouse position in world
        /// </summary>
        /// <param name="screenPosition"></param>
        /// <param name="worldCamera"></param>
        /// <returns></returns>
        public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
        {
            return worldCamera.ScreenToWorldPoint(screenPosition);
        }

        public static Vector3 GetDirToMouse(Vector3 fromPosition)
        {
            Vector3 mouseWorldPosition = GetMouseWorldPosition();
            return (mouseWorldPosition - fromPosition).normalized;
        }

        /// <summary>
        /// Is Mouse over a UI Element?
        /// Used for ignoring World clicks through UI
        /// </summary>
        /// <returns></returns>
        public static bool IsPointerOverUI()
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return true;
            }

            var pe = new PointerEventData(EventSystem.current)
            {
                position = UnityEngine.Input.mousePosition
            };
            var hits = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pe, hits);
            return hits.Count > 0;
        }
    }
}