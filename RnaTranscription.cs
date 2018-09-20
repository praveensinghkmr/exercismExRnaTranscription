using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] nucleotideRna = nucleotide.ToCharArray();
        for (int i = 0; i < nucleotideRna.Length; i++)
        {
            if (nucleotideRna[i] == 'G')
                nucleotideRna[i] = 'C';
            else if (nucleotideRna[i] == 'C')
                nucleotideRna[i] = 'G';
            else if (nucleotideRna[i] == 'T')
                nucleotideRna[i] = 'A';
            else nucleotideRna[i] = 'U';
        }
        return new string(nucleotideRna);
    }
}