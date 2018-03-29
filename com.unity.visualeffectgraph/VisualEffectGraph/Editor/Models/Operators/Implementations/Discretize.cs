using System;
using UnityEngine;

namespace UnityEditor.VFX.Operator
{
    [VFXInfo(category = "Math/Remap")]
    class Discretize : VFXOperatorFloatUnifiedWithVariadicOutput
    {
        public class InputProperties
        {
            [Tooltip("The value to be discretized.")]
            public FloatN a = 0.0f;
            [Min(0.000001f), Tooltip("The granularity.")]
            public FloatN b = 1.0f;
        }

        override public string name { get { return "Discretize"; } }

        override protected VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
        {
            return new[] { VFXOperatorUtility.Discretize(inputExpression[0], inputExpression[1]) };
        }
    }
}
