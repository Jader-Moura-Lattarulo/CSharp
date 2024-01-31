internal class ProgramBase
{

    private static bool ValidacaoPalpite(string palpite, out int resposta)
    {
        if (int.TryParse(palpite, out resposta))
        {
            if (resposta >= 1 && resposta <= 6)
            {
                return true;
            }
        }
        return false;
    }
}