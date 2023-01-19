namespace Week1;

public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 > 0) return false;
        
        var openedParentheses = new Stack<char>();
        foreach (var c in s)
        {
            if (IsOpeningParentheses(c))
            {
                openedParentheses.Push(c);
            }
            else if (IsClosingParentheses(c))
            {
                if (!(openedParentheses.TryPop(out var lastOpenedParentheses)
                      && GetClosingParenthesesOf(lastOpenedParentheses).Equals(c)))
                {
                    return false;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        return !openedParentheses.Any();
    }

    private static bool IsOpeningParentheses(char c) => new char[] { '(', '[', '{' }.Contains(c);
    private static bool IsClosingParentheses(char c) => new char[] { ')', ']', '}' }.Contains(c);

    private static char GetClosingParenthesesOf(char openingParentheses) => openingParentheses switch
    {
        '(' => ')',
        '[' => ']',
        '{' => '}',
        _ => throw new InvalidOperationException()
    };
}