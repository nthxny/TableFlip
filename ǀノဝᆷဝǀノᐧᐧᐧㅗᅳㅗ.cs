using System;

namespace TableFlip
{
    public class ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ : Exception
    {
        public ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ(string message) : base(message) { } 

        public ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ(string message, Exception innerException) : base(message, innerException) { }


        public static void FlipTable()
        {
            throw new ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ("ǀノဝᆷဝǀノ ㅗᅳㅗ Everything is fucked");
        }
    }
}
