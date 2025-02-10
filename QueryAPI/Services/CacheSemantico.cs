    // Estos métodos pueden utilizarse para implementar funcionalidad de caché semántico.
    // ComputeBagOfWordsVector crea un vector de frecuencia de palabras a partir del texto de entrada
    // CosineSimilarity calcula la similitud entre dos vectores de palabras



    // private Dictionary<string, int> ComputeBagOfWordsVector(string text)
    //     {
    //         var vector = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    //         var words = text
    //             .ToLower()
    //             .Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '\n', '\r' },
    //                    StringSplitOptions.RemoveEmptyEntries);

    //         foreach (var word in words)
    //         {
    //             if (vector.ContainsKey(word))
    //                 vector[word]++;
    //             else
    //                 vector[word] = 1;
    //         }
    //         return vector;
    //     }

    //     private double CosineSimilarity(Dictionary<string, int> vec1, Dictionary<string, int> vec2)
    //     {
    //         if (vec1 == null || vec2 == null || vec1.Count == 0 || vec2.Count == 0)
    //             return 0;

    //         double dotProduct = 0;
    //         foreach (var kvp in vec1)
    //         {
    //             if (vec2.TryGetValue(kvp.Key, out int val2))
    //             {
    //                 dotProduct += kvp.Value * val2;
    //             }
    //         }

    //         double norm1 = Math.Sqrt(vec1.Values.Sum(v => v * v));
    //         double norm2 = Math.Sqrt(vec2.Values.Sum(v => v * v));
    //         if (norm1 == 0 || norm2 == 0) return 0;

    //         return dotProduct / (norm1 * norm2);
    //     }