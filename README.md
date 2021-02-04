# Prova Take

Esse projeto tem como objetivo fazer uma API que retorna dados sobre os repositórios mais antigos da Take em C#

## Pra começar ...

Para que a interaçao com o chatbot ocorra, é preciso disponibilizar a API.
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
- Feito isso, você vai ter a url que poderá ser usada mais tarde para a integração com o bot
![2](https://user-images.githubusercontent.com/27977219/106951754-ef7bc080-670e-11eb-8bfc-bbab1b0bb6de.png)
