public static class HowMuchILove
{
    public static string Solution(int nb_petals)
    {
        int value = (nb_petals - 1) % 6;
        string[] phrases =
        {
            "I love you",
            "a little",
            "a lot",
            "passionately",
            "madly",
            "not at all"
        };

        return phrases[value];
    }
}
