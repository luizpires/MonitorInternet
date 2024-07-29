
# Monitor de Conexão com a Internet
Este é um programa simples em C# que monitora a conexão com a internet e registra falhas e sucessos em um arquivo de log. Ele foi projetado para ser executado continuamente em segundo plano, verificando a conectividade a cada minuto.

## Como Funciona
### 1. Verificação 
O programa envia um ping para o Google (google.com) a cada minuto para verificar se a conexão com a internet está ativa.
### 2. Registro: 
Se a conexão falhar, um erro é registrado no arquivo de log. Se a conexão for bem-sucedida, um registro de sucesso é adicionado ao log.
### 3. Arquivo de Log 
O arquivo de log (MonitorInternet.log) é salvo na pasta "Documentos" do usuário que executa o programa. Um novo arquivo de log é criado a cada dia.

## Como Usar
### 1. Pré-requisitos

#### 1.1 .NET Runtime 
Certifique-se de ter o .NET Runtime instalado em seu computador. Você pode baixá-lo em https://dotnet.microsoft.com/download.
#### 1.2 Serilog 
O programa utiliza a biblioteca Serilog para o registro de logs. Certifique-se de ter os pacotes NuGet Serilog e Serilog.Sinks.File instalados em seu projeto.

### 2. Compilação
2.1 Abra o projeto no Visual Studio (ou em seu editor de código C# preferido).
2.2 Compile o projeto para gerar arquivo executável (MonitorInternt.exe).

### 3. Execução
3.1 Abra um prompt de comando ou terminal.
3.2 Navegue até a pasta onde o arquivo executável foi gerado.
3.3 Execute o programa digitando MonitorInternet.exe e pressionando Enter.
3.4 O programa começará a monitorar a conexão com a internet em segundo plano.
3.5 Para parar o programa, feche a janela do prompt de comando ou terminal.

### 4. Arquivo de Log
4.1 O arquivo de log MonitorInternet.log será criado na pasta "Documentos" do usuário.
4.2 Você pode abrir o arquivo de log com qualquer editor de texto para visualizar os registros de falhas e sucessos de conexão.

## Observações
Este é um programa simples e não possui interface gráfica. A interação com o usuário é feita através do prompt de comando ou terminal.
O programa verifica a conexão com a internet a cada minuto. Você pode ajustar a frequência de verificação modificando o valor no Thread.Sleep(60000).
O programa utiliza o Google como servidor de teste. Se o Google estiver inacessível por algum motivo, o programa poderá registrar uma falha de conexão mesmo que a internet esteja funcionando.

## Código-Fonte
O código-fonte completo do programa está disponível neste repositório. Sinta-se à vontade para modificá-lo ou adaptá-lo às suas necessidades.

## Licença
Este programa é distribuído sob a licença GNU General Public License v2.0. Consulte o arquivo LICENSE para obter mais informações.

## Contato
Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato pelo e-mail: lzpires@gmail.com

## Créditos
Copyright (C) 2024 by lires
