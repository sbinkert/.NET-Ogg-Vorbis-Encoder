﻿namespace OggVorbisEncoder.Setup.Templates.Stereo44.BookBlocks.ManagedChapter0
{
    public class Page3 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
            1, 3, 3, 7, 7, 0, 0, 0, 0, 0, 5, 4, 7, 7, 0, 0,
            0, 0, 0, 5, 5, 7, 7, 0, 0, 0, 0, 0, 6, 7, 8, 8,
            0, 0, 0, 0, 0, 0, 0, 8, 8, 0, 0, 0, 0, 0, 0, 0,
            9, 10, 0, 0, 0, 0, 0, 0, 0, 9, 9, 0, 0, 0, 0, 0,
            0, 0, 11, 11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0
        };

        public CodeBookMapType MapType { get; } = CodeBookMapType.Implicit;
        public int QuantMin { get; } = -531628032;
        public int QuantDelta { get; } = 1611661312;
        public int Quant { get; } = 4;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
            4,
            3,
            5,
            2,
            6,
            1,
            7,
            0,
            8
        };
    }
}