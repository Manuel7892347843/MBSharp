# MBSharp - Lettura di array

Origine : [`MBSharp.cs`](../../../MBSharp.cs)

MBSharp supporta la lettura e la visualizzazione di array di vari tipi di dati, permettendo di gestire collezioni di dati in modo semplice.

| Tipi di lettura| Descrizione | Output |
|----------------|-------------|--------|
| ReadArray(string[] array) | Legge un array di `string` | `"ciao" \|\| "come" \|\| "stai" \|\| ....`  |
| ReadArray(int[] array) |Legge un array di `int` |  `1 \|\| 2 \|\| 3 \|\| ....` |
| ReadArray(char[] array) | Legge un array di `char` |  `'c' \|\| 'i' \|\| 'a' \|\| 'o' \|\| ....` |
| ReadArray(double[] array) | Legge un array di  `double` |  `1.2 \|\| 2.4 \|\| 3.6 \|\| ....`|
| ReadArray(float[] array) | Legge un array di `float` |  `1.2f \|\| 2.4f \|\| 3.6f \|\| ....`|
| ReadArray(bool[] array) | Legge un array di `bool` |  `true \|\| false \|\| true \|\| ....`|
| ReadArray(decimal[] array) | Legge un array di `decimal` |  `1.2M \|\| 2.4M \|\| 3.6M \|\| ....` |