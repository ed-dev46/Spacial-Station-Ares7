/*
SPACIAL STATION ARES 7
A estação internacional Ares-7 é composta por diversos módulos 
(Energia, 
Oxigênio, 
Pesquisa) 
que precisam ser monitorados por uma IA central. O sistema deve ser capaz de 
gerenciar recursos, 
responder a emergências e 
manter um registro histórico de tudo o que acontece.

Quero instanciar uma estacao, que contem modulos
para cada 4 modulos, tem que haver uma estacao de oxigenio
caso um modulo nao tenha uma estacao de energia, ele esta inoperante

modules :OK:
zones (agrupamento de modulos)
- precisa ter um modulo de energia e oxigenio para ser operante
- limite de 4 modulos em qualquer combinacao
- modulo de energia fornece energia para que os modulos da zona funcionem
- cada funcao de um modulo consome energia, quando zerada, a central deve fornecer energia, mesma coisa com oxigenio

station
*/

using Spacial_Station_Ares7.Models;

Random id = new Random();

StationModule power = new PowerModule(id.Next(1000), "power");
StationModule oxygen = new OxygenModule(id.Next(1000), "oxygen");
StationModule bedroom = new BedroomModule(id.Next(1000), "bedroom", 50);

Zone zona = new Zone();

zona.AddModule(power);
zona.AddModule(oxygen);
zona.AddModule(bedroom);

Console.WriteLine(zona.IsOperational);
Console.WriteLine(zona.Capacity);