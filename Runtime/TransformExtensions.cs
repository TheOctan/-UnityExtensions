using System.Linq;
using UnityEngine;

namespace UnityExtensions
{
    public static partial class TransformExtensions
    {
        public static void SetXYPosition(this Transform transform, Vector2 position)
        {
            transform.position = new Vector3(position.x, position.y, transform.position.z);
        }

        public static void SetXZPosition(this Transform transform, Vector2 position)
        {
            transform.position = new Vector3(position.x, transform.position.y, position.y);
        }

        public static void SetXPosition(this Transform transform, float xPosition)
        {
            Vector3 position = transform.position;
            position.x = xPosition;
            transform.position = position;
        }

        public static void SetYPosition(this Transform transform, float yPosition)
        {
            Vector3 position = transform.position;
            position.y = yPosition;
            transform.position = position;
        }

        public static void SetZPosition(this Transform transform, float zPosition)
        {
            Vector3 position = transform.position;
            position.z = zPosition;
            transform.position = position;
        }

        public static void SetXYLocalPosition(this Transform transform, Vector2 position)
        {
            transform.localPosition = new Vector3(position.x, position.y, transform.localPosition.z);
        }

        public static void SetXZLocalPosition(this Transform transform, Vector2 position)
        {
            transform.localPosition = new Vector3(position.x, transform.localPosition.y, position.y);
        }
 
        public static void SetXLocalPosition(this Transform transform, float xPosition)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.x = xPosition;
            transform.localPosition = localPosition;
        }

        public static void SetYLocalPosition(this Transform transform, float yPosition)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.y = yPosition;
            transform.localPosition = localPosition;
        }
 
        public static void SetZLocalPosition(this Transform transform, float zPosition)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.z = zPosition;
            transform.localPosition = localPosition;
        }

        public static int NearestIndex(this Transform[] nodes, Vector3 destination)
        {
            float sqrNearestDistance = Mathf.Infinity;
            var index = 0;

            for (var i = 0; i < nodes.Length; i++)
            {
                float sqrDistance = (destination - nodes[i].position).sqrMagnitude;
                if (sqrDistance < sqrNearestDistance)
                {
                    sqrNearestDistance = sqrDistance;
                    index = i;
                }
            }

            return index;
        }

        public static Vector3 NearestPosition(this Transform[] nodes, Vector3 destination)
        {
            int index = NearestIndex(nodes, destination);
            return nodes[index].position;
        }

        public static Vector3 Center(this Transform[] points)
        {
            return points.Aggregate(Vector3.zero, 
                (current, transform) => current + transform.position) / points.Length;
        }

        public static Transform FindDeep(this Transform root, string id)
        {
            if (root.name == id)
            {
                return root;
            }

            Transform final = root.Find(id);
            if (final != null)
            {
                return final;
            }

            for (var i = 0; i < root.childCount; i++)
            {
                Transform posObj = root.GetChild(i).FindDeep(id);
                if (posObj != null)
                {
                    return posObj;
                }
            }

            return null;
        }
    }
}