﻿using System;

namespace JitPad.Core
{
    public class CompileResult
    {
        public readonly byte[] AssembleImage;
        public readonly string[] Messages;

        public bool IsOk => AssembleImage.Length > 0;

        public CompileResult(byte[] assembleImage, string[] messages)
        {
            AssembleImage = assembleImage;
            Messages = messages;
        }
    }
}