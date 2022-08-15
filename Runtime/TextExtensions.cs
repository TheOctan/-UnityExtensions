using System;
using TMPro;
using UnityEngine;

namespace UnityExtensions
{
    public static partial class TextExtensions
    {
        private const int SORTING_ORDER_DEFAULT = 5000;

        public static TextMeshPro CreateWorldTextTMP(string text, Color color,
            Transform parent = null,
            Vector3 localPosition = default,
            int fontSize = 40,
            TextAlignmentOptions textAlignment = TextAlignmentOptions.Center,
            int sortingOrder = SORTING_ORDER_DEFAULT)
        {
            var gameObject = new GameObject("WorldText");

            Transform transform = gameObject.transform;
            transform.SetParent(parent, false);
            transform.localPosition = localPosition;

            var textMesh = gameObject.AddComponent<TextMeshPro>();
            textMesh.alignment = textAlignment.ToTMP();
            textMesh.text = text;
            textMesh.fontSize = fontSize;
            textMesh.color = color;
            textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;

            return textMesh;
        }

        [Obsolete("use CreateWorldTextTMP")]
        public static TextMesh CreateWorldText(string text, Color color,
            Transform parent = null,
            Vector3 localPosition = default,
            int fontSize = 40,
            TextAnchor textAnchor = TextAnchor.UpperLeft,
            TextAlignment textAlignment = TextAlignment.Left,
            int sortingOrder = SORTING_ORDER_DEFAULT)
        {
            var gameObject = new GameObject("WorldText");

            Transform transform = gameObject.transform;
            transform.SetParent(parent, false);
            transform.localPosition = localPosition;

            var textMesh = gameObject.AddComponent<TextMesh>();
            textMesh.anchor = textAnchor;
            textMesh.alignment = textAlignment;
            textMesh.text = text;
            textMesh.fontSize = fontSize;
            textMesh.color = color;
            textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;

            return textMesh;
        }

        public static void SetAlignment(this TextMeshPro text, HorizontalAlignmentOptions alignment)
        {
            text.alignment = ((int)text.alignment & 0xFF00 | (int)alignment).ToTMP();
        }

        public static void SetAlignment(this TextMeshProUGUI text, HorizontalAlignmentOptions alignment)
        {
            text.alignment = ((int)text.alignment & 0xFF00 | (int)alignment).ToTMP();
        }

        public static void SetAlignment(this TextMeshPro text, VerticalAlignmentOptions alignment)
        {
            text.alignment = ((int)text.alignment & 0x00FF | (int)alignment).ToTMP();
        }

        public static void SetAlignment(this TextMeshProUGUI text, VerticalAlignmentOptions alignment)
        {
            text.alignment = ((int)text.alignment & 0x00FF | (int)alignment).ToTMP();
        }

        public static void SetAlignment(this TextMeshPro text,
            HorizontalAlignmentOptions horizontalAlignment, VerticalAlignmentOptions verticalAlignment)
        {
            text.alignment = CombineToTMP(horizontalAlignment, verticalAlignment);
        }

        public static void SetAlignment(this TextMeshProUGUI text,
            HorizontalAlignmentOptions horizontalAlignment, VerticalAlignmentOptions verticalAlignment)
        {
            text.alignment = CombineToTMP(horizontalAlignment, verticalAlignment);
        }

        private static TextAlignmentOptions Combine(this HorizontalAlignmentOptions horizontalAlignment,
            VerticalAlignmentOptions verticalAlignment)
        {
            return (TextAlignmentOptions)((int)horizontalAlignment | (int)verticalAlignment);
        }

        public static TMPro.TextAlignmentOptions CombineToTMP(this HorizontalAlignmentOptions horizontalAlignment,
            VerticalAlignmentOptions verticalAlignment)
        {
            return (TMPro.TextAlignmentOptions)((int)horizontalAlignment | (int)verticalAlignment);
        }

        private static TMPro.TextAlignmentOptions ToTMP(this int alignment)
        {
            return (TMPro.TextAlignmentOptions)alignment;
        }

        private static TMPro.TextAlignmentOptions ToTMP(this TextAlignmentOptions alignment)
        {
            return (TMPro.TextAlignmentOptions)alignment;
        }
    }

    /// <summary>
    /// Internal horizontal text alignment options.
    /// </summary>
    public enum HorizontalAlignmentOptions
    {
        Left = 0x1,
        Center = 0x2,
        Right = 0x4,
        Justified = 0x8,
        Flush = 0x10,
        Geometry = 0x20
    }

    /// <summary>
    /// Internal vertical text alignment options.
    /// </summary>
    public enum VerticalAlignmentOptions
    {
        Top = 0x100,
        Middle = 0x200,
        Bottom = 0x400,
        Baseline = 0x800,
        Geometry = 0x1000,
        Capline = 0x2000,
    }

    // https://forum.unity.com/threads/how-to-break-up-textalignmentoptions-between-horizontal-and-vertical.493297/
    public enum TextAlignmentOptions
    {
        TopLeft = HorizontalAlignmentOptions.Left | VerticalAlignmentOptions.Top,
        Top = HorizontalAlignmentOptions.Center | VerticalAlignmentOptions.Top,
        TopRight = HorizontalAlignmentOptions.Right | VerticalAlignmentOptions.Top,
        TopJustified = HorizontalAlignmentOptions.Justified | VerticalAlignmentOptions.Top,
        TopFlush = HorizontalAlignmentOptions.Flush | VerticalAlignmentOptions.Top,
        TopGeoAligned = HorizontalAlignmentOptions.Geometry | VerticalAlignmentOptions.Top,
        Left = HorizontalAlignmentOptions.Left | VerticalAlignmentOptions.Middle,
        Center = HorizontalAlignmentOptions.Center | VerticalAlignmentOptions.Middle,
        Right = HorizontalAlignmentOptions.Right | VerticalAlignmentOptions.Middle,
        Justified = HorizontalAlignmentOptions.Justified | VerticalAlignmentOptions.Middle,
        Flush = HorizontalAlignmentOptions.Flush | VerticalAlignmentOptions.Middle,
        CenterGeoAligned = HorizontalAlignmentOptions.Geometry | VerticalAlignmentOptions.Middle,
        BottomLeft = HorizontalAlignmentOptions.Left | VerticalAlignmentOptions.Bottom,
        Bottom = HorizontalAlignmentOptions.Center | VerticalAlignmentOptions.Bottom,
        BottomRight = HorizontalAlignmentOptions.Right | VerticalAlignmentOptions.Bottom,
        BottomJustified = HorizontalAlignmentOptions.Justified | VerticalAlignmentOptions.Bottom,
        BottomFlush = HorizontalAlignmentOptions.Flush | VerticalAlignmentOptions.Bottom,
        BottomGeoAligned = HorizontalAlignmentOptions.Geometry | VerticalAlignmentOptions.Bottom,
        BaselineLeft = HorizontalAlignmentOptions.Left | VerticalAlignmentOptions.Baseline,
        Baseline = HorizontalAlignmentOptions.Center | VerticalAlignmentOptions.Baseline,
        BaselineRight = HorizontalAlignmentOptions.Right | VerticalAlignmentOptions.Baseline,
        BaselineJustified = HorizontalAlignmentOptions.Justified | VerticalAlignmentOptions.Baseline,
        BaselineFlush = HorizontalAlignmentOptions.Flush | VerticalAlignmentOptions.Baseline,
        BaselineGeoAligned = HorizontalAlignmentOptions.Geometry | VerticalAlignmentOptions.Baseline,
        MidlineLeft = HorizontalAlignmentOptions.Left | VerticalAlignmentOptions.Geometry,
        Midline = HorizontalAlignmentOptions.Center | VerticalAlignmentOptions.Geometry,
        MidlineRight = HorizontalAlignmentOptions.Right | VerticalAlignmentOptions.Geometry,
        MidlineJustified = HorizontalAlignmentOptions.Justified | VerticalAlignmentOptions.Geometry,
        MidlineFlush = HorizontalAlignmentOptions.Flush | VerticalAlignmentOptions.Geometry,
        MidlineGeoAligned = HorizontalAlignmentOptions.Geometry | VerticalAlignmentOptions.Geometry,
        CaplineLeft = HorizontalAlignmentOptions.Left | VerticalAlignmentOptions.Capline,
        Capline = HorizontalAlignmentOptions.Center | VerticalAlignmentOptions.Capline,
        CaplineRight = HorizontalAlignmentOptions.Right | VerticalAlignmentOptions.Capline,
        CaplineJustified = HorizontalAlignmentOptions.Justified | VerticalAlignmentOptions.Capline,
        CaplineFlush = HorizontalAlignmentOptions.Flush | VerticalAlignmentOptions.Capline,
        CaplineGeoAligned = HorizontalAlignmentOptions.Geometry | VerticalAlignmentOptions.Capline
    };
}