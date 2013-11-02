Feature: GameRules
	In order to poder ser el campeón mundial de RPSLS
	As a jugador
	I want to poder practicar contra un programa

#The rules of Rock-paper-scissors-lizard-Spock are:
#Scissors cut paper
#Paper covers rock
#Rock crushes lizard
#Lizard poisons Spock
#Spock smashes scissors
#Scissors decapitate lizard
#Lizard eats paper
#Paper disproves Spock
#Spock vaporizes rock
#Rock crushes scissors

Scenario Outline: Ganador juego
 Given escojo la opcion '<OpcionJugador>'
 When CPU escoge la opcion '<OpcionCPU>'
 Then veo el resultado '<Resultado>'

 Examples: 
 | OpcionJugador | OpcionCPU | Resultado |
		| Piedra        | Piedra    | Empate    |
		| Piedra        | Papel     | Pierdes   |
		| Piedra        | Tijeras   | Ganas     |
		| Piedra        | Lagarto   | Ganas     |
		| Piedra        | Spock     | Pierdes   |
		| Papel         | Piedra    | Ganas     |
		| Papel         | Papel     | Empate    |
		| Papel         | Tijeras   | Pierdes   |
		| Papel         | Lagarto   | Pierdes   |
		| Papel         | Spock     | Ganas     |
		| Tijeras       | Papel     | Ganas     |
		| Tijeras       | Lagarto   | Ganas     |
		| Tijeras       | Piedra    | Pierdes   |
		| Tijeras       | Tijeras   | Empate    |
		| Tijeras       | Spock     | Pierdes   |
		| Lagarto       | Piedra    | Pierdes   |
		| Lagarto       | Papel     | Ganas     |
		| Lagarto       | Tijeras   | Pierdes   |
		| Lagarto       | Lagarto   | Empate    |
		| Lagarto       | Spock     | Ganas     |
		| Spock         | Piedra    | Ganas     |
		| Spock         | Papel     | Pierdes   |
		| Spock         | Tijeras   | Ganas     |
		| Spock         | Lagarto   | Pierdes   |
		| Spock         | Spock     | Empate    |
