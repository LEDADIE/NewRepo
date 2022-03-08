string[] unite = { "A", "B", "C", "D", "E", "F" };

List<string> unite2 = new();

for (int i = 0; i < unite.Length; i++)
{
    for (int j = 1; j < unite.Length; j++)
    {
        if (!unite[i].ToString().Equals(unite[j].ToString()))
        {
            if (!unite2.Contains($"{unite[i]}{unite[j]}") || !unite2.Contains($"{unite[j]}{unite[i]}"))
            {
                if (!unite2.Contains($"{unite[j]}{unite[i]}"))
                {
                    unite2.Add($"{unite[i]}{unite[j]}");
                }
            }
        }
    }
}

Console.WriteLine($"Nous avons en tout {unite2.Count} couples");

Console.WriteLine(String.Join(Environment.NewLine, unite2));

Console.WriteLine();

var chunked = ChunkBy(unite2, 3);

Console.WriteLine();

/// <summary>
/// Fonction de repartition par nombre de bloc
/// </summary>
IEnumerable<IEnumerable<T>> ChunkBy<T>(IEnumerable<T> source, int chunkSize)
{
    return
        (
        source.Select((x, i) => new { Index = i, Value = x })
        .GroupBy(x => x.Index / chunkSize)
        .Select(x => x.Select(v => v.Value))
        );
}