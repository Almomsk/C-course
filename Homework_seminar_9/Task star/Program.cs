// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена


Dictionary<char, char> Pairs = new()
{
    {'{', '}'},
    {'(', ')'},
    {'[', ']'},
};


bool Balance(string text)
{
    if(string.IsNullOrEmpty(text))
    {
        return false;
    }

    var stack = new Stack<char>();
    foreach (var symbol in text)
    {
        if(Pairs.ContainsKey(symbol))
        {
            stack.Push(symbol);
        }
        else if(!Pairs.ContainsValue(symbol)) continue;
        else if(stack.Count == 0) return false;
        else if (Pairs[stack.Pop()] != symbol)
        {
            return false;
        }
    }
    return stack.Count == 0;

}

Console.WriteLine(Balance("(){[]}[{}]"));