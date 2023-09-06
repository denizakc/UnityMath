﻿#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24
        
        [StructLayout(LayoutKind.Explicit)]
        private struct FloatIntUnion
        {
            [FieldOffset(0)] public float f;
            [FieldOffset(0)] public int tmp;
        }

        /// <summary>Implementation of the fast inverse square root algorithm - From 2x to 6x faster (even faster for bigger numbers)</summary>
        /// <remarks>https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24</remarks>
        [MethodImpl(IL)] public static float fsqrt(this float z)
        {
            if (z == 0) return 0;
            FloatIntUnion u;
            u.tmp = 0;
            u.f = z;
            u.tmp -= 1 << 23; // Subtract 2^m.
            u.tmp >>= 1; // Divide by 2.
            u.tmp += 1 << 29; // Add ((b + 1) / 2) * 2^m.
            return u.f;
        }

        
        /// <inheritdoc cref="fsqrt(float)"/>
        [MethodImpl(IL)] public static float4 fsqrt(this float4 f) => new(f.x.fsqrt(), f.y.fsqrt(), f.z.fsqrt(), f.w.fsqrt());
        /// <inheritdoc cref="fsqrt(float)"/>
        [MethodImpl(IL)] public static float3 fsqrt(this float3 f) => new(f.x.fsqrt(), f.y.fsqrt(), f.z.fsqrt());
        /// <inheritdoc cref="fsqrt(float)"/>
        [MethodImpl(IL)] public static float2 fsqrt(this float2 f) => new(f.x.fsqrt(), f.y.fsqrt()); // to never simplify to new f2(f.xy.fastsqrt())


        /// Returns the distance between a and b (fast but low accuracy)
        [MethodImpl(IL)] public static float fdistance(float4 a, float4 b) => fsqrt((a - b).lengthsq());
        /// <inheritdoc cref="fdistance(float4, float4)"/>
        [MethodImpl(IL)] public static float fdistance(float3 a, float3 b) => fsqrt((a - b).lengthsq());
        /// <inheritdoc cref="fdistance(float4, float4)"/>
        [MethodImpl(IL)] public static float fdistance(float2 a, float2 b) => fsqrt((a - b).lengthsq());
        

        /// Returns the length of the vector (fast but low accuracy)
        [MethodImpl(IL)] public static float flength(this float4 f) => fsqrt(f.lengthsq());
        /// <inheritdoc cref="flength(float4)"/>
        [MethodImpl(IL)] public static float flength(this float3 f) => fsqrt(f.lengthsq());
        /// <inheritdoc cref="flength(float4)"/>
        [MethodImpl(IL)] public static float flength(this float2 f) => fsqrt(f.lengthsq());
        
        
        /// https://github.com/SunsetQuest/Fast-Integer-Log2 --------------------------
        [StructLayout(LayoutKind.Explicit)]
        private struct ConverterStruct2
        {
            [FieldOffset(0)] public ulong asLong;
            [FieldOffset(0)] public double asDouble;
        }

        /// Same as Log2_SunsetQuest3 except it uses FP64.
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int log2int(this int value)
        {
            mathx.ConverterStruct2 a;  a.asLong = 0; a.asDouble = (uint)value;
            return (int)((a.asLong >> 52) + 1) & 0xFF;
        }
        
        // MOD ---------------------------------------------------------------------

        /// fast mod function using the inverse Mod
        [MethodImpl(IL)] public static float fastmodinv(this int f, float invMod, float mod) => (f * invMod).frac() * mod;

        /// Exp function approximation, around 2x faster than math.exp()
        [MethodImpl(IL)] public static float fexp(float f) => 1 / (f * f * (0.48f + 0.235f * f) + 1 + f);
        /// <inheritdoc cref="fexp(float)"/>
        [MethodImpl(IL)] public static float2 fexp(float2 f) => new(fexp(f.x), fexp(f.y));
        /// <inheritdoc cref="fexp(float)"/>
        [MethodImpl(IL)] public static float3 fexp(float3 f) => new(fexp(f.x), fexp(f.y), fexp(f.z));
        /// <inheritdoc cref="fexp(float)"/>
        [MethodImpl(IL)] public static float4 fexp(float4 f) => new(fexp(f.x), fexp(f.y), fexp(f.z), fexp(f.w));
        
        
        #region Deprecated

        // [BurstCompile]
        // [StructLayout(LayoutKind.Explicit)]
        // private struct FloatUInt32Union
        // {
        //     [FieldOffset(0)] public float f;
        //     [FieldOffset(0)] public uint u;
        // }
        //
        //
        // /// returns 1/x using fast math
        // [MethodImpl(IL)]
        // public static float frcp(this float x)
        // {
        //     FloatUInt32Union fiu = new();
        //     fiu.f = x;
        //     fiu.u = (0xbe6eb3beU - fiu.u) >> 1; // pow( x, -0.5 )
        //     return fiu.f * fiu.f; // pow( pow(x,-0.5), 2 ) = pow( x, -1 ) = 1.0 / x
        // }
        //
        //
        // /// returns 1/x using fast math
        // [MethodImpl(IL)]
        // public static float frcp(this int x)
        // {
        //     FloatUInt32Union fiu = new();
        //     fiu.f = x;
        //     fiu.u = (0xbe6eb3beU - fiu.u) >> 1; // pow( x, -0.5 )
        //     return fiu.f * fiu.f; // pow( pow(x,-0.5), 2 ) = pow( x, -1 ) = 1.0 / x
        // }

        #endregion
    }
}