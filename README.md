# Prova Take

Esse projeto tem como objetivo fazer uma API que retorna dados sobre os repositórios mais antigos da Take em C#

## Pra começar ...

Para que a interação com o chatbot ocorra, é preciso disponibilizar a API.
Pra isso, eu usei o [Ngrok](https://ngrok.com).
Ele pode ser usado gratuitamente.

Depois de clonar este repositório e executar o seu programa, será necessário utilizar o ngrok para isso tenho um passo a passo bem simples:

- Primeiramente você vai precisar saber a porta que a sua aplicação está rodando. Pra saber isso é só observar a saida do seu console. 
Essa minha aplicação está rodando nas portas 5001 (https) e 5000 (http)
![1](https://user-images.githubusercontent.com/27977219/106951032-01109880-670e-11eb-8b39-63efa63d7aa0.png)

- Depois disso voce vai abrir o seu .exe do ngrok e colocar o comando de acordo com o número da porta da sua aplicação:
```C#
ngrok http 5001
```
  em alguns casos dá erro e é preciso rodá-lo com o seguninte comando:
```C#
ngrok http https://localhost:5001
```
- Feito isso, você vai ter a url que poderá ser usada mais tarde para a integração com o bot
![2](https://user-images.githubusercontent.com/27977219/106951754-ef7bc080-670e-11eb-8bfc-bbab1b0bb6de.png)

    Uma dica pra vocês: para copiar o link use o enter! o ctrl + c vai desligar o ngrok :/

## O ChatBot

Primeiramente você precisa entrar no site https://account.blip.ai/login e se registrar

No site já existe um passo a passo para dar os seus primeiros passos na criação do chatbot.

Para importar o fluxo disponibilizado neste repositório você vai seguir os seguintes passos. É super simples o/

- Você vai baixar o .json de nome "provatake"
- Vai abrir o Builder

![image](https://user-images.githubusercontent.com/27977219/106982228-6f6f4e00-6742-11eb-9327-c9c0132c0ceb.png)

- Clicar em configuração

![image](https://user-images.githubusercontent.com/27977219/106982285-8f067680-6742-11eb-82e6-9ba0188d6cb0.png)

- Depois em versões e carregar fluxo

![image](https://user-images.githubusercontent.com/27977219/106982434-e1479780-6742-11eb-882f-7190d9db3337.png)

## Para configurar o chatbot para acessar a sua API pelo ngrok

Lembra daquela URL que o ngrok cria pra nós?
Exatamente, vamos usá-la!

- Entrando em configuração (no builder), você vai ver o item "variáveis de configuração"

![image](https://user-images.githubusercontent.com/27977219/106982781-777bbd80-6743-11eb-92b1-93df1387a39b.png)

- Clicando nele você vai conseguir configurar uma variavel que você poderá guardar essa sua url. O bom disso é que sempre que precisar usar a sua api e o ngrok gerar uma url diferente pra você, só vai ter que mudar em um lugar! Incrivel ne?

![image](https://user-images.githubusercontent.com/27977219/106982943-cfb2bf80-6743-11eb-9b1d-468dd8d0f81b.png)

### Usando a variável de configuração
Pra usar essa variável nas suas chamada http também é bem simples.

Em qualquer lugar que você precisa delas é só colocar 
```
{{ config.nomeDaVariavelQueVoceCriou }}
```
![image](https://user-images.githubusercontent.com/27977219/106983302-6c755d00-6744-11eb-88c9-42f2c5a6a74c.png)

### Prontinho!
