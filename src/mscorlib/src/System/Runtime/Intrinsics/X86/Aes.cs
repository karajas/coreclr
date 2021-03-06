// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.Intrinsics;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>
    /// This class provides access to Intel AES hardware instructions via intrinsics
    /// </summary>
    [CLSCompliant(false)]
    public static class Aes 
    {
        public static bool IsSupported { get => IsSupported; }
        
        /// <summary>
        /// __m128i _mm_aesdec_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<sbyte> Decrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) => Decrypt(value, roundKey);
        /// <summary>
        /// __m128i _mm_aesdec_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<byte> Decrypt(Vector128<byte> value, Vector128<byte> roundKey) => Decrypt(value, roundKey);

        /// <summary>
        /// __m128i _mm_aesdeclast_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<sbyte> DecryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) => DecryptLast(value, roundKey);
        /// <summary>
        /// __m128i _mm_aesdeclast_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<byte> DecryptLast(Vector128<byte> value, Vector128<byte> roundKey) => DecryptLast(value, roundKey);

        /// <summary>
        /// __m128i _mm_aesenc_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<sbyte> Encrypt(Vector128<sbyte> value, Vector128<sbyte> roundKey) => Encrypt(value, roundKey);
        /// <summary>
        /// __m128i _mm_aesenc_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<byte> Encrypt(Vector128<byte> value, Vector128<byte> roundKey) => Encrypt(value, roundKey);

        /// <summary>
        /// __m128i _mm_aesenclast_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<sbyte> EncryptLast(Vector128<sbyte> value, Vector128<sbyte> roundKey) => EncryptLast(value, roundKey);
        /// <summary>
        /// __m128i _mm_aesenclast_si128 (__m128i a, __m128i RoundKey)
        /// </summary>
        public static Vector128<byte> EncryptLast(Vector128<byte> value, Vector128<byte> roundKey) => EncryptLast(value, roundKey);

        /// <summary>
        /// __m128i _mm_aesimc_si128 (__m128i a)
        /// </summary>
        public static Vector128<sbyte> InvisibleMixColumn(Vector128<sbyte> value) => InvisibleMixColumn(value);
        /// <summary>
        /// __m128i _mm_aesimc_si128 (__m128i a)
        /// </summary>
        public static Vector128<byte> InvisibleMixColumn(Vector128<byte> value) => InvisibleMixColumn(value);

        /// <summary>
        /// __m128i _mm_aeskeygenassist_si128 (__m128i a, const int imm8)
        /// </summary>
        public static Vector128<sbyte> KeygenAssist(Vector128<sbyte> value, byte control) => KeygenAssist(value, control);
        /// <summary>
        /// __m128i _mm_aeskeygenassist_si128 (__m128i a, const int imm8)
        /// </summary>
        public static Vector128<byte> KeygenAssist(Vector128<byte> value, byte control) => KeygenAssist(value, control);

    }

}
