using Serilog;
using Serilog.Sinks.File; // Adicione esta linha para usar o sink de arquivo
using System;
using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace MonitorInternet;

class Program
{
    static bool continuarTestes = false; // Variável para controlar a execução dos testes

    static void Main(string[] args)
    {
        // Configuração do Serilog (mesma do exemplo anterior)
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File(
                path: $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\MonitorInternet.log",
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
            )
            .CreateLogger();


        Thread threadTestes = new Thread(ExecutarTestes); // Cria uma thread separada para os testes

        while (true)
        {
            Console.WriteLine("Digite 'iniciar' para começar os testes ou 'parar' para encerrar:");
            string comando = Console.ReadLine().ToLower();

            if (comando == "iniciar")
            {
                if (!continuarTestes) // Verifica se os testes já não estão em execução
                {
                    continuarTestes = true;
                    threadTestes.Start(); // Inicia a thread de testes
                    Log.Information("Testes iniciados.");
                }
                else
                {
                    Console.WriteLine("Os testes já estão em execução.");
                }
            }
            else if (comando == "parar")
            {
                if (continuarTestes)
                {
                    continuarTestes = false;
                    threadTestes.Join(); // Aguarda a thread de testes terminar
                    Log.Information("Testes encerrados.");
                }
                else
                {
                    Console.WriteLine("Os testes não estão em execução.");
                }
            }
            else
            {
                Console.WriteLine("Comando inválido.");
            }
        }
    }

    static void ExecutarTestes()
    {
        while (continuarTestes) // Executa os testes enquanto a variável continuarTestes for verdadeira
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("google.com");

                if (reply.Status != IPStatus.Success)
                {
                    Log.Error("Falha na conexão com a internet detectada.");
                }
                else
                {
                    Log.Information("Conexão com a internet OK.");
                }

            }
            catch (PingException ex)
            {
                Log.Error($"Erro ao verificar a conexão: {ex.Message}");
            }

            Thread.Sleep(60000); // Aguarda 1 minuto
        }
    }
}