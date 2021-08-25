using System;

namespace TableFlip
{
    public class ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ : Exception
    {
        public ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ(string message) : base("ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ " + message) { } 

        public ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ(string message, Exception innerException) : base("ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ " + message, innerException) { }


        public static void FlipTable()
        {
            throw new ǀノဝᆷဝǀノᐧᐧᐧㅗᅳㅗ("Everything is fucked");
        }
    }
}
