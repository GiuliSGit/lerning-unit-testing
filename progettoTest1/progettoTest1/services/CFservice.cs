namespace progettoTest1.services
{
    public class CFservice
    {
        public bool sevocale(char c)
        {
            char minuscolo = char.ToLower(c);
            char[] vocali = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char v in vocali)
            {
                if (v == minuscolo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
