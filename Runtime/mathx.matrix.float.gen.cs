﻿#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {

        /// <inheritdoc cref="math.float4x4(float, float, float, float, float, float, float, float, float, float, float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float4x4 f4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33);

        /// <inheritdoc cref="math.float3x4(float, float, float, float, float, float, float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32);

        /// <inheritdoc cref="math.float4x2(float, float, float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.float3x4(float, float, float, float, float, float, float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23);

        /// <inheritdoc cref="math.float3x3(float, float, float, float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22);

        /// <inheritdoc cref="math.float3x2(float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(float m00, float m01, float m10, float m11, float m20, float m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.float2x4(float, float, float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.float2x3(float, float, float, float, float, float)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(float m00, float m01, float m10, float m11, float m20, float m21)
            => new(m00, m01, m10, m11, m20, m21);
        
        /// <inheritdoc cref="math.float2x2(float, float, float, float)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(float m00, float m01, float m10, float m11)
            => new(m00, m01, m10, m11);
        
        
        #region Matrix Gen
        
        
        
        /// <inheritdoc cref="math.float4x4(float4, float4, float4, float4)"/>
        [MethodImpl(IL)] public static float4x4 f4x4(float4 a, float4 b, float4 c, float4 d) => new(a,b,c,d);
        ///<inheritdoc cref="math.float4x3(float4, float4, float4)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(float4 a, float4 b, float4 c) => new(a,b,c);
        /// <inheritdoc cref="math.float4x2(float4, float4)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(float4 a, float4 b) => new(a,b);
        /// <inheritdoc cref="math.float3x4(float3, float3, float3, float3)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(float3 a, float3 b, float3 c, float3 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.float3x3(float3, float3, float3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(float3 a, float3 b, float3 c) => new(a,b,c);
        /// <inheritdoc cref="math.float3x2(float3, float3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(float3 a, float3 b) => new(a,b);
        /// <inheritdoc cref="math.float2x4(float2, float2, float2, float2)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(float2 a, float2 b, float2 c, float2 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.float2x3(float2, float2, float2)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(float2 a, float2 b, float2 c) => new(a,b,c);
        /// <inheritdoc cref="math.float2x2(float2, float2)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(float2 a, float2 b) => new(a,b);
        
        

        /// Creates a matrix with the same value in every row
        [MethodImpl(IL)] public static float4x4 f4x4(this float4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(this float4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(this float3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float2 f) => new(f, f);


        /// <inheritdoc cref="math.float4x4(float)"/>
        [MethodImpl(IL)] public static float4x4 f4x4(this float f) => new(f);
        /// <inheritdoc cref="math.float4x3(float)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(this float f) => new(f);
        /// <inheritdoc cref="math.float4x2(float)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float f) => new(f);
        /// <inheritdoc cref="math.float3x4(float)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(this float f) => new(f);
        /// <inheritdoc cref="math.float3x3(float)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float f) => new(f);
        /// <inheritdoc cref="math.float3x2(float)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float f) => new(f);
        /// <inheritdoc cref="math.float2x4(float)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float f) => new(f);
        /// <inheritdoc cref="math.float2x3(float)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float f) => new(f);
        /// <inheritdoc cref="math.float2x2(float)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float f) => new(f);

        #endregion
        
        #region Matrix Truncation

        /// Truncates the matrix to the specified size
        [MethodImpl(IL)] public static float2x2 f2x2(this float2x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float3x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float4x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float2x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float3x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float4x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float3x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float4x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float3x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float4x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float3x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float4x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float4x3 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float3x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(this float4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz, m.c3.xyz);
        
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float4x3 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float4x4 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(this float4x4 m) => new(m.c0, m.c1, m.c2);

        #endregion
        
    }
}