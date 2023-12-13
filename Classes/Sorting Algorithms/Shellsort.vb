Public Class Shellsort
    Public Sub New()
    End Sub

    Public Sub ShellSort(ByVal array As Integer())
        ' Se obtiene la longitud del array
        Dim n As Integer = array.Length
        ' Se obtiene el tamaño de espacio entre elementos
        Dim gap As Integer = n \ 2

        Console.WriteLine(vbLf & "Start of Shell Sort Algorithm:")

        ' Mientras el espacio entre elementos sea mayor que 0
        While gap > 0
            Console.WriteLine($"{vbLf}Current Gap: {gap}")

            ' Aplicar el algoritmo de inserción para cada "subarray" con el tamaño de gap
            For i As Integer = gap To n - 1
                ' Guardar el valor actual del elemento en una variable temporal
                Dim temp As Integer = array(i)
                Dim j As Integer = i

                Console.WriteLine($"{vbLf}Compare {temp} to elements of the subarray:")

                ' Realizar la inserción
                While j >= gap AndAlso array(j - gap) > temp
                    ' Desplazar elementos hacia la derecha hasta encontrar la posición correcta
                    array(j) = array(j - gap)
                    j -= gap

                    PrintArray(array)
                End While

                ' Colocar el valor temporal en la posición correcta en el subarray
                array(j) = temp
                Console.WriteLine($"Insert {temp} in the subarray {j} position:")
                PrintArray(array)
            Next

            ' Reducir el espacio entre elementos a la mitad en cada iteración
            gap \= 2
        End While

        Console.WriteLine($"{vbLf}End of the Shell Sort Algorithm:")
    End Sub

    Private Sub PrintArray(ByVal array As Integer())
        For Each num As Integer In array
            Console.Write(num & " ")
        Next
        Console.WriteLine()
    End Sub
End Class
